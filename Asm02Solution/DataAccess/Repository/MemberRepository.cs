using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using BusinessObject.Models;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public Member GetMemberByID(int memId) => MemberDAO.Instance.GetMemberByID(memId);
        public Member GetMemberByName(string memName) => MemberDAO.Instance.GetMemberByName(memName);

        public IEnumerable<Member> GetMembers()
        {
            return MemberDAO.Instance.GetMemberList();
        }
        public void InsertMember(Member member) => MemberDAO.Instance.AddNew(member);
        public void DeleteMember(int memId) => MemberDAO.Instance.Remove(memId);
        public void UpdateMember(Member member) => MemberDAO.Instance.Update(member);

        public List<Member> GetMemberByCityAndCountry(string city, string country) => MemberDAO.Instance.GetMemberByCityAndCountry(city, country);

        public IEnumerable<Member> GetMemberByIDList(int memid)
        {
            return MemberDAO.Instance.GetMemberByIDList(memid);
        }
    }
}
