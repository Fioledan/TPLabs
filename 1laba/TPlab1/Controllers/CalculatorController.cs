using System.Web.Mvc;
using TPlab1.Models;

namespace TPlab1.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            CalculatorModel model = new CalculatorModel();
            model.Operation = "+";
            ViewBag.CheckValue = 10;
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(CalculatorModel model, string btn)
        {
            ViewBag.CheckValue = 10;

            if (btn == "Очистить")
            {
                model.Operand1 = null;
                model.Operand2 = null;
                model.Operation = "+";
                model.Result = null;

                Session["OperationInfo"] = null;

                ModelState.Clear();
                return View(model);
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            switch (model.Operation)
            {
                case "+":
                    model.Result = (float)(model.Operand1.Value + model.Operand2.Value);
                    break;
                case "-":
                    model.Result = (float)model.Operand1.Value - model.Operand2.Value;
                    break;
                case "*":
                    model.Result = (float)(model.Operand1.Value * model.Operand2.Value);
                    break;
                case "/":
                    model.Result = (float)model.Operand1.Value / model.Operand2.Value;
                    break;
            }

            string operationInfo = model.Operand1 + " " + model.Operation + " " + model.Operand2 + " = " + model.Result;
            Session["OperationInfo"] = operationInfo;

            ModelState.Remove("Result");
            return View(model);
        }

        public ActionResult Result()
        {
            string operationInfo = Session["OperationInfo"] as string;
            string changedInfo = "";

            if (!string.IsNullOrEmpty(operationInfo))
            {
                int index = operationInfo.IndexOf("=");

                if (index != -1)
                {
                    changedInfo = operationInfo.Remove(index, 1);
                    changedInfo = changedInfo.Insert(index, "равно");
                }
                else
                {
                    changedInfo = operationInfo;
                }
            }

            ViewBag.OperationInfo = operationInfo;
            ViewBag.ChangedInfo = changedInfo;

            return View();
        }
    }
}