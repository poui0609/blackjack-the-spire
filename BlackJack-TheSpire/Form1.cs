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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            safe.Text = 금고.ToString(); // 금고에 있는 돈, 소지금 게임 로딩할 때 초기화
            money.Text = 소지금.ToString();
        }

        private void 룰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rules rules = new rules();
            rules.Show();
        }

        int 금고;
        int 소지금;
        int 배팅금액; //배팅한 금액
        int 배팅금; //배팅 할 금액

        private void battingbutton_Click(object sender, EventArgs e)
        {
            배팅금 = int.Parse(batting.Text);

            if (배팅금 <= 0)   //0이하로 배팅하면 빠꾸
            {
                MessageBox.Show("제대로된 금액을 입력하시오");
                return;
            }

            if ( 배팅금액 != 0) //배팅금 배팅금액에 넣고 지움
            {
                배팅금액 = 배팅금;
                batting.Text = "";
            }
            else //이미 배팅했으면 빠꾸
            {
                MessageBox.Show("이미 배팅을 했습니다");
                return;
            }
        }

        private void deck_Click(object sender, EventArgs e) // 남은 카드들 보여주기
        {
            // 보여주는 명령어를 나중에 추가할 예정
        }
    }
}
