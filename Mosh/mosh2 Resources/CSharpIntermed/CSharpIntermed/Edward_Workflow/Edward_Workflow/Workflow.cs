using System.Collections;
using System.Collections.Generic;

namespace Edward_Workflow
{
    public class Workflow : IEnumerable
    {
        private readonly IList<IActivity> _activites;
 
        public Workflow()
        {
            _activites = new List<IActivity>();
        }
 
        public void RegisterActivity(IActivity activity)
        {
            _activites.Add(activity);
        }
 
        public IEnumerator GetEnumerator()
        {
            return _activites.GetEnumerator();
        }
    }
}