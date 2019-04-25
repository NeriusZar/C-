using System;
using System.Windows.Forms;

namespace UI
{
    enum Errors { Connection_Error, Inserting_Error, Uploading_Error, Incorrect_Information_Error };
    class ErrorHandling
    {
        public static void PrintError(Exception e)
        {
            Console.WriteLine(e);
        }
        public static void Show_Connection_Error()
        {
            MessageBox.Show(Errors.Connection_Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Show_Inserting_Error()
        {
            MessageBox.Show(Errors.Inserting_Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Show_Uploading_Error()
        {
            MessageBox.Show(Errors.Uploading_Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void Show_IncorrectInfo_Error()
        {
            MessageBox.Show(Errors.Incorrect_Information_Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
