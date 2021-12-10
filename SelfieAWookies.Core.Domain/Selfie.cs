using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfieAWookies.Core.Domain
{
    /// <summary>
    /// Represente un selfie lié à un wookie
    /// </summary>
    public class Selfie
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public int WookieId { get; set; }
        public Wookie Wookie { get; set; }
        #endregion

    }
}
