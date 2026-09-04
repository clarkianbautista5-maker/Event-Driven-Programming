namespace QueueApplication
{
    public partial class QueuingForm : Form
    {
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();

            //showy the other form
            CashierWindowQueueForm cashierWindow = new CashierWindowQueueForm();
            cashierWindow.Show();

        }
        private CashierClass cashier;
        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        
    }
}
