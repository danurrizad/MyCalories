using System.Runtime.InteropServices;

namespace MyCalories
{
    public partial class FormBMI : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse

        );
        public FormBMI()
        {
            InitializeComponent();
        }

        private void FormBMI_Load(object sender, EventArgs e)
        {
            //Transparan Background Panel Calculate dan Result
            panelCalculate.BackColor = Color.FromArgb(220, 255, 255, 255);
            panelResult.BackColor = Color.FromArgb(220, 255, 255, 255);

            //Panel dan Button Menjadi Rounded Border
            panelCalculate.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelCalculate.Width, panelCalculate.Height, 50, 50));
            panelResult.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelResult.Width, panelResult.Height, 50, 50));
            panelTbTB.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTbTB.Width, panelTbTB.Height, 50, 50));
            panelTbBB.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTbBB.Width, panelTbBB.Height, 50, 50));
            panelTbUmur.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, panelTbUmur.Width, panelTbUmur.Height, 50, 50));
            btnCalclulate.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCalclulate.Width, btnCalclulate.Height, 50, 50));
            btnClear.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btnClear.Width, btnClear.Height, 50, 50));


            //Button Mousedown dan Mouseover menjadi Transparan
            btnCalclulate.FlatAppearance.MouseDownBackColor = Color.Black;
            btnCalclulate.FlatAppearance.MouseOverBackColor = Color.Black;

            btnClear.FlatAppearance.MouseDownBackColor = Color.Black;
            btnClear.FlatAppearance.MouseOverBackColor = Color.Black;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbBB.Text = "";
            tbTB.Text = "";
            numericUmur.Value = 0;
            rdbtnLaki.Checked = false;
            rdbtnPerempuan.Checked = false;

        }
    }
}