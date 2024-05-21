using IArea;
using IDetalhesArea;

namespace IVeiculos
{
    public partial class DetalheArea : Form
    {
        public DetalheArea()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Area10 area10Form = new Area10();
            area10Form.Show();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            Area3 area3Form = new Area3();
            area3Form.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Area7 area7Form = new Area7();
            area7Form.Show();
        }
    }
}
