using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SampleWebApp.Data;

namespace SampleWebApp
{
    public partial class _Default : Page
    {
        SampleVetData _vetDataObj = new SampleVetData();
        public List<VetDataModel> vetSampleData = new List<VetDataModel>();
        protected void Page_Load(object sender, EventArgs e)
        {
            vetSampleData = GetAllSearchResults();
        }
        public List<VetDataModel> GetAllSearchResults()
        {
            return _vetDataObj.GetAllVetData();

        }
        public void GetSearchResultsByZip(Object sender, EventArgs e)
        {

            string zipCode = postalCode.Value;
            if (string.IsNullOrEmpty(zipCode))
            {
                return;
            }
            vetSampleData = _vetDataObj.GetVetDataByZip(Convert.ToInt32(zipCode));
        }
        public void GetSearchResultsByState(Object sender, EventArgs e)
        {
            string state = storestate.Value;
            string city = storecity.Value;
            if (!string.IsNullOrEmpty(state) && !string.IsNullOrEmpty(city))
            {
                vetSampleData = _vetDataObj.GetVetDataByLocation(state, city);
            }
        }

    }
}