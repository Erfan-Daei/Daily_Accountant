using System.Data;
using System.Data.SqlClient;
using Accountant.UI;

namespace Accountant
{
    ///////////////////////////////////////////////////////////////////////////////////////////
    // پروژه حسابرسی روزانه
    // عرفان داعی - محمد احسان آبله کوبها
    // در این پروژه کاربر با ورود به حساب کاربری خود ورودی و خروجی حساب خود را در برنامه ذخیره
    // و میتواند به تمام آنها دسترسی داشته باشد
    ///////////////////////////////////////////////////////////////////////////////////////////
    
    public class MainApp
    {
        public string Query;
        public SqlConnection Connection = new SqlConnection("Data Source=LENOVO-THINKBOO\\SQLEXPRESS;Initial Catalog=ACCOUNTANT_TRIAL_DB;Integrated Security=True");
        public SqlCommand Command;
        public SqlDataReader Reader;
        public SqlDataAdapter Adapter;
        public DataTable DataTbl;

        [STAThread]

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LogIn());
        }
    }
}
