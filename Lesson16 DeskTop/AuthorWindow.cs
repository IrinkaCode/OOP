using Lesson16.Console;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson16_DeskTop
{
    public partial class AuthorWindow : Form
    {
        private User currentUser;
        public AuthorWindow(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void AuthorWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string topic = txtTopic.Text;
            int ageLimit = (int)numAgeLimit.Value;
            string content = txtContent.Text;
        }
    }
}
