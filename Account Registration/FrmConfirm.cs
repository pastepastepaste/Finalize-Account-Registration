using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Account_Registration.StudentInfoClass;

namespace Account_Registration
{
    public partial class FrmConfirm : Form

    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        public FrmConfirm()
        {
            InitializeComponent();
            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);


        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            adds.Text = DelAddress(StudentInfoClass.Address);
            program.Text = DelProgram(StudentInfoClass.Program);
            lastname.Text = DelLastName(StudentInfoClass.LastName);
            firstname.Text = DelFirstName(StudentInfoClass.FirstName);
            middlename.Text = DelMiddleName(StudentInfoClass.MiddleName);
            age.Text = DelNumAge(StudentInfoClass.Age).ToString();
            contact.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            student.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
