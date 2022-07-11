using BusinessObject;
using System.Collections;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> GetMembers();
        Member GetMemberByID(int id);
        void DeleteMember(int id);
        IEnumerable<Member> GetMembers1();
        void InsertMember(Member member);
        void UpdateMember(Member member);
        IEnumerable<Member> SortDesc();
        Member GetMemberByIDandName(int id, string name);
        IEnumerable<Member> GetCityAndCountry(string city, string country);
    }
}

