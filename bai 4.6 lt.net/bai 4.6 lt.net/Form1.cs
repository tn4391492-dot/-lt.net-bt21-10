
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        private BindingList<Student> students =
            new BindingList<Student>();

        private BindingSource bsStudents =
            new BindingSource();

        private int nextId = 1;
        private string selectedAvatarPath = "";

        public Form1()
        {
            InitializeComponent();
            CauHinhDuLieu();
            GanSuKien();
        }

        private void CauHinhDuLieu()
        {
            txtStudentId.ReadOnly = true;

            cboGender.Items.Clear();
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;

            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.BorderStyle = BorderStyle.FixedSingle;

            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.ReadOnly = true;
            dgvStudents.MultiSelect = false;
            dgvStudents.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvStudents.Columns.Clear();

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colStudentId",
                HeaderText = "Mã sinh viên",
                DataPropertyName = "StudentId"
            });

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFullName",
                HeaderText = "Họ tên",
                DataPropertyName = "FullName"
            });

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAge",
                HeaderText = "Tuổi",
                DataPropertyName = "Age"
            });

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colGender",
                HeaderText = "Giới tính",
                DataPropertyName = "Gender"
            });

            bsStudents.DataSource = students;
            dgvStudents.DataSource = bsStudents;

            txtStudentId.DataBindings.Clear();
            txtFullName.DataBindings.Clear();
            txtAge.DataBindings.Clear();
            cboGender.DataBindings.Clear();

            txtStudentId.DataBindings.Add(
                "Text", bsStudents, "StudentId");

            txtFullName.DataBindings.Add(
                "Text", bsStudents, "FullName",
                true, DataSourceUpdateMode.OnPropertyChanged);

            txtAge.DataBindings.Add(
                "Text", bsStudents, "Age",
                true, DataSourceUpdateMode.Never);

            cboGender.DataBindings.Add(
                "SelectedItem", bsStudents, "Gender",
                true, DataSourceUpdateMode.OnPropertyChanged);

            XoaThongTin();
        }

        private void GanSuKien()
        {
            btnAdd.Click -= btnAdd_Click;
            btnUpdate.Click -= btnUpdate_Click;
            btnDelete.Click -= btnDelete_Click;
            btnChooseAvatar.Click -= btnChooseAvatar_Click;
            btnExportCsv.Click -= btnExportCsv_Click;
            dgvStudents.SelectionChanged -= dgvStudents_SelectionChanged;

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnChooseAvatar.Click += btnChooseAvatar_Click;
            btnExportCsv.Click += btnExportCsv_Click;
            dgvStudents.SelectionChanged += dgvStudents_SelectionChanged;
        }

        private string TaoMaSinhVien()
        {
            return "SV" + nextId++.ToString("D3");
        }

        private bool KiemTraThongTin(out int tuoi)
        {
            tuoi = 0;

            if (txtFullName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                txtFullName.Focus();
                return false;
            }

            if (!int.TryParse(txtAge.Text, out tuoi) ||
                tuoi < 1 || tuoi > 120)
            {
                MessageBox.Show("Tuổi phải từ 1 đến 120!");
                txtAge.Focus();
                return false;
            }

            if (cboGender.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int tuoi;

            if (!KiemTraThongTin(out tuoi))
                return;

            Student sv = new Student
            {
                StudentId = TaoMaSinhVien(),
                FullName = txtFullName.Text.Trim(),
                Age = tuoi,
                Gender = cboGender.SelectedItem.ToString(),
                AvatarPath = selectedAvatarPath
            };

            students.Add(sv);
            bsStudents.Position = students.Count - 1;

            MessageBox.Show("Thêm sinh viên thành công!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student sv = bsStudents.Current as Student;

            if (sv == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần cập nhật!");
                return;
            }

            int tuoi;

            if (!KiemTraThongTin(out tuoi))
                return;

            sv.FullName = txtFullName.Text.Trim();
            sv.Age = tuoi;
            sv.Gender = cboGender.SelectedItem.ToString();
            sv.AvatarPath = selectedAvatarPath;

            bsStudents.ResetCurrentItem();
            HienThiAvatar(sv);

            MessageBox.Show("Cập nhật thành công!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student sv = bsStudents.Current as Student;

            if (sv == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc muốn xóa " + sv.FullName + "?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                students.Remove(sv);

                if (students.Count == 0)
                {
                    XoaThongTin();
                }
                else
                {
                    bsStudents.Position = Math.Min(
                        bsStudents.Position, students.Count - 1);
                    HienThiAvatar(bsStudents.Current as Student);
                }
            }
        }

        private void btnChooseAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh đại diện";
                ofd.Filter =
                    "Ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (Image img = Image.FromFile(ofd.FileName))
                    {
                        Image anhMoi = new Bitmap(img);
                        Image anhCu = picAvatar.Image;

                        picAvatar.Image = anhMoi;

                        if (anhCu != null)
                            anhCu.Dispose();
                    }

                    selectedAvatarPath = ofd.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể mở ảnh: " + ex.Message);
                }
            }
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            Student sv = bsStudents.Current as Student;
            HienThiAvatar(sv);
        }

        private void HienThiAvatar(Student sv)
        {
            Image anhCu = picAvatar.Image;
            picAvatar.Image = null;

            if (anhCu != null)
                anhCu.Dispose();

            selectedAvatarPath = "";

            if (sv == null)
                return;

            selectedAvatarPath = sv.AvatarPath ?? "";

            if (!string.IsNullOrWhiteSpace(selectedAvatarPath) &&
                File.Exists(selectedAvatarPath))
            {
                try
                {
                    using (Image img = Image.FromFile(selectedAvatarPath))
                    {
                        picAvatar.Image = new Bitmap(img);
                    }
                }
                catch
                {
                    picAvatar.Image = null;
                }
            }
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Xuất danh sách sinh viên";
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "DanhSachSinhVien.csv";
                sfd.DefaultExt = "csv";
                sfd.AddExtension = true;

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (StreamWriter sw = new StreamWriter(
                        sfd.FileName, false, new UTF8Encoding(true)))
                    {
                        sw.WriteLine(
                            "StudentId,FullName,Age,Gender,AvatarPath");

                        foreach (Student sv in students)
                        {
                            sw.WriteLine(
                                CsvField(sv.StudentId) + "," +
                                CsvField(sv.FullName) + "," +
                                sv.Age + "," +
                                CsvField(sv.Gender) + "," +
                                CsvField(sv.AvatarPath));
                        }
                    }

                    MessageBox.Show("Xuất CSV thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xuất CSV: " + ex.Message);
                }
            }
        }

        private string CsvField(string value)
        {
            if (value == null)
                value = "";

            return "\"" + value.Replace("\"", "\"\"") + "\"";
        }

        private void XoaThongTin()
        {
            txtStudentId.Clear();
            txtFullName.Clear();
            txtAge.Clear();
            cboGender.SelectedIndex = -1;
            selectedAvatarPath = "";

            Image anhCu = picAvatar.Image;
            picAvatar.Image = null;

            if (anhCu != null)
                anhCu.Dispose();
        }

        private void lblFullName_Click(object sender, EventArgs e)
        {
        }
    }
}
