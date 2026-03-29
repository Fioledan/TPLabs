using System.Text;
using System.Web;
using System.Web.Mvc;
using TPlab2.Models;

namespace TPlab2.Helpers
{
    public static class StudentHtmlHelpers
    {
        public static IHtmlString RenderStudentsOuter(this HtmlHelper html, StudentModel[] students, string title)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<h3>" + title + "</h3>");
            sb.Append("<table border='1' cellpadding='5'>");
            sb.Append("<tr>");
            sb.Append("<th>Номер</th>");
            sb.Append("<th>ФИО</th>");
            sb.Append("<th>Группа</th>");
            sb.Append("<th>Возраст</th>");
            sb.Append("<th>Телефон</th>");
            sb.Append("<th>Средний балл</th>");
            sb.Append("</tr>");

            int i = 0;
            while (i < students.Length)
            {
                sb.Append("<tr>");
                sb.Append("<td>" + students[i].Id + "</td>");
                sb.Append("<td>" + students[i].FullName + "</td>");
                sb.Append("<td>" + students[i].Group + "</td>");
                sb.Append("<td>" + students[i].Age + "</td>");
                sb.Append("<td>" + students[i].Phone + "</td>");
                sb.Append("<td>" + students[i].AverageScore + "</td>");
                sb.Append("</tr>");

                i++;
            }

            sb.Append("</table>");

            return new HtmlString(sb.ToString());
        }
    }
}