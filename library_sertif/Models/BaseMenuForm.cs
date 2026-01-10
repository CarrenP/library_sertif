using System.Windows.Forms;

namespace library_sertif.forms
{
    public class BaseMenuForm : Form
    {
        protected int UserId;

        public BaseMenuForm(int userId)
        {
            UserId = userId;
        }
        
        public virtual string ShowMenuInfo()
        {
            return "Base Menu";
        }
    }
}
