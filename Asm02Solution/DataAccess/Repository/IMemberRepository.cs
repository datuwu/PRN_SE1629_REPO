using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using BusinessObject.Models;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        IEnumerable<Member> GetMemberByIDList(int memid);
        Member GetMemberByID(int memId);
        Member GetMemberByName(string memName);
        void InsertMember(Member member);
        void DeleteMember(int memId);
        void UpdateMember(Member member);
        List<Member> GetMemberByCityAndCountry(string text1, string text2);
    }
}
