using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form,View
    {
        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();
        }

        public void Notify(Model m)
        {
            UpdateScoreEnd(((TwoZeroFourEightModel)m).GetScore());
        }

        public void UpdateScoreEnd(int score)
        {

            lblScore.Text = "Game over " + "\nScore :fk " + score;
        }
        private void TwoZeroFourEightScoreView_Load(object sender, EventArgs e)
        {

        }
    }
}
