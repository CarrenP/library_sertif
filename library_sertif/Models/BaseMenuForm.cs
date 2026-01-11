using System.Windows.Forms;

namespace library_sertif.forms
{
    // Base class untuk menu form
    // Menyimpan UserId agar bisa dipakai di form turunan
    public class BaseMenuForm : Form
    {
        protected int UserId; // ID user yang sedang login

        public BaseMenuForm(int userId)
        {
            UserId = userId; // set UserId dari parameter
        }

        // Method yang bisa dioverride oleh form turunan
        // untuk menampilkan info menu masing-masing
        public virtual string ShowMenuInfo()
        {
            return "Base Menu";
        }
    }
}
