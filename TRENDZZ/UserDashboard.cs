using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRENDZZ
{
    public partial class UserDashboard : Form
    {
        private int userId;
        public UserDashboard(int loggedInUserId)
        {
            InitializeComponent();
            userId = loggedInUserId; // Store user ID
        }
    }
}
