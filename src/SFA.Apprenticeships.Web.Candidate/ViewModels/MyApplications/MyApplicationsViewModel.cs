﻿namespace SFA.Apprenticeships.Web.Candidate.ViewModels.MyApplications
{
    using System.Collections.Generic;
    using System.Linq;
    using Domain.Entities.Applications;

    public class MyApplicationsViewModel
    {
        public MyApplicationsViewModel(IEnumerable<MyApplicationViewModel> applications)
        {
            this.AllApplications = applications;
        }

        public IEnumerable<MyApplicationViewModel> AllApplications { get; private set; }

        public IEnumerable<MyApplicationViewModel> InProgressApplications
        {
            get { return AllApplications.Where(each => each.ApplicationStatus == ApplicationStatuses.InProgress); }
        }

        public IEnumerable<MyApplicationViewModel> SubmittedApplications
        {
            get
            {
                return AllApplications.Where(each =>
                    each.ApplicationStatus == ApplicationStatuses.Submitting ||
                    each.ApplicationStatus == ApplicationStatuses.Submitted);
            }
        }

        public IEnumerable<MyApplicationViewModel> SuccessfulApplications
        {
            get { return AllApplications.Where(each => each.ApplicationStatus == ApplicationStatuses.Successful); }
        }

        public IEnumerable<MyApplicationViewModel> UnsuccessfulApplications
        {
            get { return AllApplications.Where(each => each.ApplicationStatus == ApplicationStatuses.Unsuccessful); }
        }

        public IEnumerable<MyApplicationViewModel> DraftApplications
        {
            get { return AllApplications.Where(each => each.ApplicationStatus == ApplicationStatuses.Draft); }
        }
    }
}
