using Espl.Linkup.Common.Leave;
using Espl.Linkup.Domain.Leave.Holiday;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Espl.Linkup.Web.Controllers.Leave.Holidays
{
    public class HolidayController : ApiController
    {
        static List<Holiday> holidayList = new List<Holiday>();
        // GET: api/Holiday
        public IHttpActionResult Get()
        {

            holidayList.Add(new Holiday
            {
                ID = 1,
                Title = "Christmas",
                WeekDay = "Sunday",
                HolidayType = "Fixed",
                HolidayDate = new DateTime()
            });
            holidayList.Add(new Holiday
            {
                ID = 1,
                Title = "New Year",
                WeekDay = "Sunday",
                HolidayType = "Fixed",
                HolidayDate = new DateTime().AddDays(5)
            });
            return Ok(holidayList);
        }

        // GET: api/Holiday/5
        public IHttpActionResult Get(int id)
        {
            var result = holidayList.Where(p => p.ID == id).FirstOrDefault();
            return Ok(result);
        }

        // POST: api/Holiday
        public IHttpActionResult Post(Holiday value)
        {
            holidayList.Add(value);
            value.ID = holidayList.Count;
            return Ok(true);
        }

        // PUT: api/Holiday/5
        public IHttpActionResult Put(int id, Holiday value)
        {
            Holiday result = holidayList.Where(p => p.ID == id).FirstOrDefault();
            result.ID = value.ID;
            result.Title = value.Title;
            result.WeekDay = value.WeekDay;
            result.HolidayType = value.HolidayType;
            result.HolidayDate = new DateTime().AddDays(5);
            return Ok(result);
        }

        // DELETE: api/Holiday/5
        public IHttpActionResult Delete(int id)
        {
            Holiday result = holidayList.Where(p => p.ID == id).FirstOrDefault();
            var resultflag = holidayList.Remove(result);
            return Ok(resultflag);
        }
    }
}
