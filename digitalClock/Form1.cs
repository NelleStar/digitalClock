namespace digitalClock
{
    public partial class Clock : Form
    {
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        public Clock()
        {
            InitializeComponent();
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
        }

        private void t_Tick(object? sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;             
            int ss = DateTime.Now.Second;

            string time = "";
            string am_pm = "";

            if (hh < 12)
            {
                am_pm = "AM";
            }
            else
            {
                am_pm = "PM";
            }

            if (hh == 0)
            { 
                hh = 12;
            }   
            
            if (hh > 12) 
            {
                hh -= 12;
            }

            if (hh < 10 )
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }

            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }

            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            time += am_pm;

            label1.Text = time;
        }
    }
}
