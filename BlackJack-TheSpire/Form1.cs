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
            setting();
        }

        private void 룰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rules rules = new rules();
            rules.Show();
        }

        int 금고;
        int 점수;
        int 목표점수;
        int 숫자; //블랙잭해서 나온 숫자
        float 배율;
        int 턴; // 이번 라운드에서 할 수 있는 턴
        int 현재턴; // 이번 라운드에서 몇번 째 턴인지

        void setting() //라운드 시작할 때 갱신
        {
            금고 = 1;//여기에 저장한 값 넣어야징
            점수 = 0;
            목표점수 = 1; // 여기도 저장한 내용에서 뽑아와서 넣기
            숫자 = 0;
            배율 = 1;
            턴 = 1; // 여기도 저장한 내용에서 뽑아와서 넣기
            현재턴 = 0;
            showscore();
            showturn();
        }
        
        void showscore() //점수 보여주는 메소드
        {
            score.Text = $"{점수.ToString()} / {목표점수.ToString()}" ;
        }
        void showturn() // 남은 턴 보여주는 메소드. 턴 지나면 마지막에 하나씩 넣어주셈
        {
              turn.Text = $"{현재턴.ToString()} / {턴.ToString()}";
        }
        void showget()//받을 점수 보여주는 메소드. 점수랑 배율 관련되서 마지막에 넣어주셈
        {
            get.Text = $"받는 점수 :{Math.Ceiling(숫자 * 배율).ToString()}";
        }
        void shownumodds()
        {
            num.Text = 숫자.ToString();
            odds.Text = 배율.ToString();
        }

        private void foldbutten_Click(object sender, EventArgs e)//폴드 누르면 뽑은 패 초기화 하는거 추가좀
        {
            숫자 = 0;
            배율 = 1;
            shownumodds();
            showget();
            if (점수 > 0)
            {
                점수 = 점수 / 2;
            }
            showscore();
        }

        private void deck_Click(object sender, EventArgs e) // 남은 카드들 보여주기
        {
            // 보여주는 명령어를 나중에 추가할 예정
        }

        private void draw_Click(object sender, EventArgs e)
        {
            //카드 뽑는 명령어 부탁바람. 뽑고 나서 숫자랑 배율 채워주면 됌
            showget(); //받을 점수 보여주는 메소드임
        }

        private void stand_Click(object sender, EventArgs e)// 블랙잭에서 이거 누르면 카드 뽑는거. 추가해주셈
        {
            //++++++++++++
            //여기다가 추가좀
            //+++++++++++
            점수 = 점수 + (int)Math.Ceiling(숫자 * 배율);
            숫자 = 0;
            배율 = 1;
            shownumodds();
            showscore();
            showget();
        }
    }
    //gg
}
