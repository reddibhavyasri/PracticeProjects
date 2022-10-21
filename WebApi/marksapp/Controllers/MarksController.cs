using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using clientshow.Models;
namespace clientshow.Controllers
{
    public class marksController : Controller
    {
        // GET: marks
        public ActionResult Index()
        {
            List<mark> emplist = new List<mark>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44300//api/");

                var responseTask = client.GetAsync("Values");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readData = result.Content.ReadAsAsync<mark[]>();
                    readData.Wait();
                    var empdata = readData.Result;
                    foreach (var item in empdata)
                    {
                        emplist.Add(new mark
                        {
                            student_id = item.student_id,
                            student_name = item.student_name,
                            subject_marks = item.subject_marks
                        });

                    }
                }
            }
            return View(emplist);

        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]

        public ActionResult Create(mark empmodel)
        {


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44300//api/Values");

                var emp = new mark
                {
                    student_id = empmodel.student_id,
                    student_name = empmodel.student_name,
                    subject_marks = empmodel.subject_marks
                };

                var postTask = client.PostAsJsonAsync<mark>(client.BaseAddress, emp);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readtaskResult = result.Content.ReadAsAsync<mark>();

                    readtaskResult.Wait();
                    var dataInserted = readtaskResult.Result;
                }


            }

            return RedirectToAction("Index");
        }
    }
}