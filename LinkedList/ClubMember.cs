using System;
using System.Collections;

namespace LinkedList {
	public class ClubMember : IComparable {
		public int Nr { get; set; }
		public string Fname { get; set; }
		public string Lname { get; set; }
		public int Age { get; set; }

		public ClubMember(int nr, string fname, string lname, int age) {
			this.Nr = nr;
			this.Fname = fname;
			this.Lname = lname;
			this.Age = age;
		}

		public override string ToString() {
			return this.Nr + " " + this.Fname + " " + this.Lname + " " + this.Age;
		}

		public int CompareTo(object y) {
			int Result = 0;
			ClubMember Other = (ClubMember)y;

			Result = this.Nr.CompareTo(Other.Nr);

			if(Result == 0) {
				Result = this.Fname.CompareTo(Other.Fname);
			}

			if (Result == 0) {
				Result = this.Age.CompareTo(Other.Age);
			}

			return Result;
		}
	}
    public override bool Equal(ClubMember a, ClubMember b)
    {
        bool result = false;
        if (a.Nr == b.Nr && a.Fname==b.Fname && a.Lname==b.Lname && a.Age==b.Age)
        {
            result = true;
        }
        return result;
    }
    public override string GetHashCode(ClubMember a)
    {
        return a.Nr.GetHashCode() + a.Fname.GetHashCode() + a.Lname + a.Age;
    }
   
}
