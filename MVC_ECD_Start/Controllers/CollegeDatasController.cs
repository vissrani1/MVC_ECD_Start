using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_ECD_Start.Data;
using MVC_ECD_Start.Models;
using Newtonsoft.Json;

namespace MVC_ECD_Start.Controllers
{
    public class CollegeDatasController : Controller
    {
        private readonly StudentDBContext _context;
        HttpClient httpclient;
        static string BASE_URL = "https://api.data.gov/ed/collegescorecard/v1/schools";
        static string API_KEY = "sOaqyejLHpoOUEY4air3g7GSbQmYJ3VDeJIZykvz";


        public CollegeDatasController(StudentDBContext context)
        {
            _context = context;
        }

        // GET: CollegeDatas
        public async Task<IActionResult> Index()
        {
            httpclient = new HttpClient();
            httpclient.DefaultRequestHeaders.Accept.Clear();
            httpclient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpclient.DefaultRequestHeaders.Accept.Add(
            new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            string College_Data_API_PATH = BASE_URL;
            //+ "?limit=100";
            httpclient.BaseAddress = new Uri(College_Data_API_PATH);
            string collegeData = "";
            List <CollegeData> collegeDatas = null;
            try
            {
                HttpResponseMessage response = httpclient.GetAsync(College_Data_API_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    collegeData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                }
                if (!collegeData.Equals(""))
                {

                    collegeDatas = JsonConvert.DeserializeObject<List<CollegeData>>(collegeData);


                    return View(await _context.CollegesData.ToListAsync());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }

            // GET: CollegeDatas/Details/5
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var collegeData = await _context.CollegesData
                    .FirstOrDefaultAsync(m => m.ID == id);
                if (collegeData == null)
                {
                    return NotFound();
                }

                return View(collegeData);
            }

            // GET: CollegeDatas/Create
            public IActionResult Create()
            {
                return View();
            }

            // POST: CollegeDatas/Create
            // To protect from overposting attacks, enable the specific properties you want to bind to.
            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("ID,FederalSchoolCode,SchoolName,SchoolCity,SchoolState,SchoolURL,AverageAdmittedSATScores,CumulativeACTMedianScore,OverallAdmissionRate,InStateTuitionCost,OutStateTuitionCost,EnrolledSttudentSize")] CollegeData collegeData)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(collegeData);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                return View(collegeData);
            }

            // GET: CollegeDatas/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var collegeData = await _context.CollegesData.FindAsync(id);
                if (collegeData == null)
                {
                    return NotFound();
                }
                return View(collegeData);
            }

            // POST: CollegeDatas/Edit/5
            // To protect from overposting attacks, enable the specific properties you want to bind to.
            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, [Bind("ID,FederalSchoolCode,SchoolName,SchoolCity,SchoolState,SchoolURL,AverageAdmittedSATScores,CumulativeACTMedianScore,OverallAdmissionRate,InStateTuitionCost,OutStateTuitionCost,EnrolledSttudentSize")] CollegeData collegeData)
            {
                if (id != collegeData.ID)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(collegeData);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!CollegeDataExists(collegeData.ID))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(collegeData);
            }

            // GET: CollegeDatas/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var collegeData = await _context.CollegesData
                    .FirstOrDefaultAsync(m => m.ID == id);
                if (collegeData == null)
                {
                    return NotFound();
                }

                return View(collegeData);
            }

            // POST: CollegeDatas/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var collegeData = await _context.CollegesData.FindAsync(id);
                _context.CollegesData.Remove(collegeData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool CollegeDataExists(int id)
            {
                return _context.CollegesData.Any(e => e.ID == id);
            }
        }
    }
}
