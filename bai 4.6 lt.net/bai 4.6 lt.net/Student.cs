
using System.ComponentModel;

namespace QuanLySinhVien
{
    public class Student : INotifyPropertyChanged
    {
        private string studentId = "";
        private string fullName = "";
        private int age;
        private string gender = "";
        private string avatarPath = "";

        public string StudentId
        {
            get { return studentId; }
            set
            {
                if (studentId != value)
                {
                    studentId = value;
                    OnPropertyChanged("StudentId");
                }
            }
        }

        public string FullName
        {
            get { return fullName; }
            set
            {
                if (fullName != value)
                {
                    fullName = value;
                    OnPropertyChanged("FullName");
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (age != value)
                {
                    age = value;
                    OnPropertyChanged("Age");
                }
            }
        }

        public string Gender
        {
            get { return gender; }
            set
            {
                if (gender != value)
                {
                    gender = value;
                    OnPropertyChanged("Gender");
                }
            }
        }

        public string AvatarPath
        {
            get { return avatarPath; }
            set
            {
                if (avatarPath != value)
                {
                    avatarPath = value;
                    OnPropertyChanged("AvatarPath");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(
                this, new PropertyChangedEventArgs(name));
        }
    }
}
