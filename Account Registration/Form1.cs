namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            Program.Items.Add("Bachelor Science of Information Technology");
            Program.Items.Add("Bachelor Science of Computer Science");
            Program.Items.Add("Bachelor Science of Information Systems");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = First.Text;
            StudentInfoClass.LastName = Last.Text;
            StudentInfoClass.MiddleName = Middle.Text;
            StudentInfoClass.Address = add.Text;
            StudentInfoClass.Program = Program.Text;
            StudentInfoClass.Age = Int64.Parse(age.Text.ToString());
            StudentInfoClass.ContactNo = Int64.Parse(num.Text.ToString());
            StudentInfoClass.StudentNo = Int64.Parse(Student.Text.ToString());
            FrmConfirm frmConfirm = new FrmConfirm();
            frmConfirm.ShowDialog();

        }
    }
    public class StudentInfoClass
    {

        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string text);

        public static string FirstName = " ";
        public static string LastName = " ";
        public static string MiddleName = " ";
        public static string Address = " ";
        public static string Program = " ";
        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        public static string GetFirstName(string FirstName)
        {
            return FirstName;
        }
        public static string GetLastName(string LastName)
        {
            return LastName;
        }
        public static string GetMiddleName(string MiddleName)
        {
            return MiddleName;
        }
        public static string GetAddress(string Address)
        {
            return Address;
        }
        public static string GetProgram(string Program)
        {
            return Program;
        }
        public static long GetAge(long Age)
        {
            return Age;
        }
        public static long GetContactNo(long ContactNo)
        {
            return ContactNo;
        }
        public static long GetStudentNo(long StudentNo)
        {
            return StudentNo;
        }


    }
}
