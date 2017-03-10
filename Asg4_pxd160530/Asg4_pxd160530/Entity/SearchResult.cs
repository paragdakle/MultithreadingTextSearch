using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asg4_pxd160530.Entity
{
    /// <remarks>
    /// Author: Parag Pravin Dakle
    /// Course: Human Computer Interaction CS 6326 Spring 2017
    /// Net ID: pxd160530
    /// </remarks>
    /// <summary>
    /// <c>class SearchResult</c>
    /// The file search result entity model class.
    /// </summary>
    class SearchResult
    {
        /// <summary>
        /// Class attributes.
        /// matchLine: The file line where a search match was found.
        /// lineNumber: The line number of the matching line in the file.
        /// </summary>
        public string matchLine { get; }
        public int lineNumber { get; }

        /// <summary>
        /// Parameterized Constructor of the class.
        /// Sets the class attributes.
        /// </summary>
        /// <param name="line">The line containing the search term</param>
        /// <param name="lineNumber">The line number of the matching line.</param>
        public SearchResult(string line, int lineNumber)
        {
            this.matchLine = line;
            this.lineNumber = lineNumber;
        }
    }
}
