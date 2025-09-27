using System;
using System.Web;
using PersonalLib; // DLL đa năng

public partial class api : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.ContentType = "application/json";

        try
        {
            int day = int.Parse(Request.Form["day"]);
            int month = int.Parse(Request.Form["month"]);
            int year = int.Parse(Request.Form["year"]);

            FunPredict fp = new FunPredict();
            string message = fp.PredictBirthday(day, month, year);

            // Tạo JSON thủ công (vì .NET 2.0 chưa có JSON serializer)
            message = message.Replace("\"", "\\\""); // escape dấu "
            string json = "{\"message\":\"" + message + "\"}";

            Response.Write(json);
        }
        catch (Exception ex)
        {
            string err = ex.Message.Replace("\"", "\\\"");
            string json = "{\"message\":\"Loi: " + err + "\"}";
            Response.Write(json);
        }

        Response.End();
    }
}
