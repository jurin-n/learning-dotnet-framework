using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAccessSample
{
    public class DbHelper
    {
        public static String getConnectionString()
        {
            //パスワード抜きのConnectionStringを取得し
            //SqlConnectionStringBuilderオブジェクト作成する。
            String tempConnectionString = "Data Source=localhost; Database = master;User ID=user01;Password=; Min Pool Size=100;Max Pool Size=1000";
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(tempConnectionString);

            //パスワードは、暗号化した状態で格納する。
            //ここのロジックで、暗号化したパスワードを復号化して
            //builder.Password にセットすることが考えられる。
            builder.Password = "user01password";
            return builder.ToString();
        }
    }
}
