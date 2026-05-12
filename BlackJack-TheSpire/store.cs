using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack_TheSpire
{
    public partial class store : Form
    {
        public store()
        {
            InitializeComponent();
        }
        int item1, item2, item3, card1, card2, card3; //아이템과 카드 번호 저장하는 변수
        int safe;

        private void store_Load(object sender, EventArgs e) //랜덤 돌려서 아이템 채워넣기, 카드 채워넣기
        {

        }

        private void selectbtn1_Click(object sender, EventArgs e)
        {

        }

        private void selectbtn2_Click(object sender, EventArgs e)
        {

        }

        private void pass_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selectbtn3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pushdeck(int sex)
        {
            //덱에 넣는 명령어
        }
        private void pushitem(int 기모띠)
        {
            //아이템에 넣는 명령어
        }
    }
}
