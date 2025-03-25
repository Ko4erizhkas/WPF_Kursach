using WPF_Kursach.AnotherDirectory.ControlClasses;

namespace WPF_Kursach.AnotherDirectory.MainForms
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        private List<Hospital> hospitals = new List<Hospital>();
        private List<Polyclinic> polyclinics = new List<Polyclinic>();
        private ListBox lstHospitals, lstPolyclinics;
        private DataGridView dgvStaff, dgvPatients;
        private Button btnAddHospital, btnAddPolyclinic, btnAddDoctor, btnAddPatient;
        private readonly string HospitalsFilePath;
        private readonly string PolyclinicsFilePath;
        private GeneratorFiles GF = new GeneratorFiles(); 
        public MainForm()
        {

            string projectFolder = Application.StartupPath;
            HospitalsFilePath = Path.Combine(projectFolder, "hospitals.json");
            PolyclinicsFilePath = Path.Combine(projectFolder, "polyclinics.json");

            InitializeComponents();
            GF.GenerateFile(projectFolder, HospitalsFilePath, hospitals);
            GF.GenerateFile(projectFolder, PolyclinicsFilePath, polyclinics);

        }

        private void InitializeComponents()
        {
            Width = 800;
            Height = 600;

            lstHospitals = new ListBox { Left = 10, Top = 10, Width = 200, Height = 200 };
            lstPolyclinics = new ListBox { Left = 220, Top = 10, Width = 200, Height = 200 };
            lstHospitals.SelectedIndexChanged += (s, e) => UpdateGrids();
            lstPolyclinics.SelectedIndexChanged += (s, e) => UpdateGrids();

            dgvStaff = new DataGridView { Left = 10, Top = 220, Width = 400, Height = 150, ReadOnly = true };
            dgvPatients = new DataGridView { Left = 10, Top = 380, Width = 400, Height = 150, ReadOnly = true };
            ConfigureStaffGrid();
            ConfigurePatientsGrid();
            dgvStaff.CellClick += DgvStaff_CellClick;
            dgvPatients.CellClick += DgvPatients_CellClick;

            btnAddHospital = new Button { Text = "Добавить больницу", Left = 430, Top = 10, Width = 200 };
            btnAddPolyclinic = new Button { Text = "Добавить поликлинику", Left = 430, Top = 40, Width = 200 };
            btnAddDoctor = new Button { Text = "Добавить врача", Left = 430, Top = 220, Width = 200 };
            btnAddPatient = new Button { Text = "Добавить пациента", Left = 430, Top = 250, Width = 200 };

            btnAddHospital.Click += (s, e) => AddHospital();
            btnAddPolyclinic.Click += (s, e) => AddPolyclinic();
            btnAddDoctor.Click += (s, e) => AddDoctor();
            btnAddPatient.Click += (s, e) => AddPatient();

            Controls.AddRange(new Control[] { lstHospitals, lstPolyclinics, dgvStaff, dgvPatients, btnAddHospital, btnAddPolyclinic, btnAddDoctor, btnAddPatient });
        }
        private void AddHospital()
        {
            using (var form = new Form { Text = "Регистрация больницы", Width = 300, Height = 200 })
            {
                TextBox txtName = new TextBox { Top = 10, Left = 10, Width = 200, PlaceholderText = "Название" };
                TextBox txtAddress = new TextBox { Top = 40, Left = 10, Width = 200, PlaceholderText = "Адрес" };
                TextBox txtDesc = new TextBox { Top = 70, Left = 10, Width = 200, PlaceholderText = "Описание" };
                TextBox txtCapacity = new TextBox { Top = 100, Left = 10, Width = 200, PlaceholderText = "Вместимость" };
                Button btnOk = new Button { Text = "ОК", Top = 130, Left = 10 };
                form.Controls.AddRange(new Control[] { txtName, txtAddress, txtDesc, txtCapacity, btnOk });

                btnOk.Click += (s, e) =>
                {
                    Hospital hospital = new Hospital(txtName.Text, txtAddress.Text, int.Parse(txtCapacity.Text), txtDesc.Text);
                    hospitals.Add(hospital);
                    UpdateLists();
                    form.Close();
                };
                form.ShowDialog();
            }
        }

        private void AddPolyclinic()
        {
            using (var form = new Form { Text = "Регистрация поликлиники", Width = 300, Height = 250 })
            {
                TextBox txtName = new TextBox { Top = 10, Left = 10, Width = 200, PlaceholderText = "Название" };
                TextBox txtAddress = new TextBox { Top = 40, Left = 10, Width = 200, PlaceholderText = "Адрес" };
                TextBox txtDesc = new TextBox { Top = 70, Left = 10, Width = 200, PlaceholderText = "Описание" };
                TextBox txtCapacity = new TextBox { Top = 100, Left = 10, Width = 200, PlaceholderText = "Вместимость" };
                ComboBox cmbHospital = new ComboBox { Top = 130, Left = 10, Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
                cmbHospital.Items.Add("Нет привязки");
                cmbHospital.Items.AddRange(hospitals.ToArray());
                cmbHospital.SelectedIndex = 0;
                Button btnOk = new Button { Text = "ОК", Top = 160, Left = 10 };
                form.Controls.AddRange(new Control[] { txtName, txtAddress, txtDesc, txtCapacity, cmbHospital, btnOk });

                btnOk.Click += (s, e) =>
                {
                    Hospital attached = cmbHospital.SelectedIndex == 0 ? null : (Hospital)cmbHospital.SelectedItem;
                    Polyclinic polyclinic = new Polyclinic(txtName.Text, txtAddress.Text, int.Parse(txtCapacity.Text), txtDesc.Text, attached);
                    polyclinics.Add(polyclinic);
                    UpdateLists();
                    form.Close();
                };
                form.ShowDialog();
            }
        }

        private void AddDoctor()
        {
            Organization org = GetSelectedOrganization();
            if (org == null) { MessageBox.Show("Выберите организацию"); return; }

            using (var form = new Form { Text = "Добавить врача", Width = 300, Height = 200 })
            {
                TextBox txtFullName = new TextBox { Top = 10, Left = 10, Width = 200, PlaceholderText = "Имя" };
                TextBox txtSurname = new TextBox { Top = 40, Left = 10, Width = 200, PlaceholderText = "Фамилия" };
                TextBox txtSpec = new TextBox { Top = 70, Left = 10, Width = 200, PlaceholderText = "Специализация" };
                Button btnOk = new Button { Text = "ОК", Top = 100, Left = 10 };
                form.Controls.AddRange(new Control[] { txtFullName, txtSurname, txtSpec, btnOk });

                btnOk.Click += (s, e) =>
                {
                    Doctor doctor = new Doctor(txtFullName.Text, txtSurname.Text, "", txtSpec.Text, Guid.NewGuid().ToString(), "123-456", "Нет", "123-456-789-00");
                    org.AddStaff(doctor);
                    UpdateGrids();
                    form.Close();
                };
                form.ShowDialog();
            }
        }

        private void AddPatient()
        {
            Organization org = GetSelectedOrganization();
            if (org == null) { MessageBox.Show("Выберите организацию"); return; }
            if (org.StaffList.Count == 0) { MessageBox.Show("Нет врачей"); return; }

            using (var form = new Form { Text = "Добавить пациента", Width = 300, Height = 150, AutoSize = true })
            {
                TextBox txtFullName = new TextBox { Top = 10, Left = 10, Width = 200, PlaceholderText = "Имя" };
                TextBox txtSurname = new TextBox { Top = 40, Left = 10, Width = 200, PlaceholderText = "Фамилия" };
                Button btnOk = new Button { Text = "ОК", Top = 70, Left = 10 };
                form.Controls.AddRange(new Control[] { txtFullName, txtSurname, btnOk });

                btnOk.Click += (s, e) =>
                {
                    Patient patient = new Patient(txtFullName.Text, txtSurname.Text, "");
                    if (org is Hospital hospital)
                        hospital.AddPatient(patient, hospital.StaffList[0] as Doctor);
                    else if (org is Polyclinic polyclinic)
                        polyclinic.AddPatient(patient, new List<Doctor> { polyclinic.StaffList[0] as Doctor });
                    UpdateGrids();
                    form.Close();
                };
                form.ShowDialog();
            }
        }

        private void DgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var employee = dgvStaff.Rows[e.RowIndex].DataBoundItem as Doctor; // Используем Doctor вместо Employee
                if (employee != null)
                {
                    MessageBox.Show($"Выбран сотрудник: {employee.FullName} {employee.Surname}, Специализация: {employee.Specialization}");
                }
            }
        }

        private void DgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var patient = dgvPatients.Rows[e.RowIndex].DataBoundItem as Patient;
                if (patient != null)
                {
                    string doctorInfo = patient.CurrentDoctor != null
                        ? $"Лечащий врач: {patient.CurrentDoctor.FullName} {patient.CurrentDoctor.Surname}"
                        : $"Лечащие врачи: {string.Join(", ", patient.CurrentDoctors?.Select(d => $"{d.FullName} {d.Surname}") ?? new string[0])}";
                    MessageBox.Show($"Выбран пациент: {patient.FullName} {patient.Surname}\n{doctorInfo}");
                }
            }
        }           

        private Organization GetSelectedOrganization()
        {
            if (lstHospitals.SelectedItem != null) return (Hospital)lstHospitals.SelectedItem;
            if (lstPolyclinics.SelectedItem != null) return (Polyclinic)lstPolyclinics.SelectedItem;
            return null;
        }

        private void UpdateLists()
        {
            lstHospitals.DataSource = null;
            lstHospitals.DataSource = hospitals;
            lstHospitals.DisplayMember = "NameOrg";
            lstPolyclinics.DataSource = null;
            lstPolyclinics.DataSource = polyclinics;
            lstPolyclinics.DisplayMember = "NameOrg";
        }

        private void UpdateGrids()
        {
            var org = GetSelectedOrganization();
            if (org == null)
            {
                dgvStaff.DataSource = null;
                dgvPatients.DataSource = null;
                return;
            }

            dgvStaff.DataSource = null;
            dgvStaff.DataSource = org.StaffList; // Предполагается, что StaffList — это List<Doctor>

            dgvPatients.DataSource = null;
            dgvPatients.DataSource = org is Hospital h ? h.Patients : (org as Polyclinic)?.Patients;
        }

        private void ConfigureStaffGrid()
        {
            dgvStaff.AutoGenerateColumns = false;
            dgvStaff.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Имя", DataPropertyName = "FullName" });
            dgvStaff.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Фамилия", DataPropertyName = "Surname" });
            dgvStaff.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Специализация", DataPropertyName = "Specialization" });
        }

        private void ConfigurePatientsGrid()
        {
            dgvPatients.AutoGenerateColumns = false;
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Имя", DataPropertyName = "FullName" });
            dgvPatients.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Фамилия", DataPropertyName = "Surname" });
        }

    }
}
