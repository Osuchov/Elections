using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elections
{
    class presidentCandidate
    {
        private int id;
        private string name;
        private string surname;
        private string city;
        private long votes;
        private long votePercent;

        static public void loadPresidentCandidates()
        {

        }

        public void msgInfo()
        {
            System.Windows.MessageBox.Show(this.name + " " + this.Surname);
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string City { get => city; set => city = value; }
        public long Votes { get => votes; set => votes = value; }
        public long VotePercent { get => votePercent; set => votePercent = value; }

    }
}
