using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DataAccess
{
    public class MemberDAO
    {

        //Using Singleton Pattern
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        //----------------------------------------------------------------
        public List<Member> GetMemberList()
        {
            List<Member> Members;
            try
            {
                using FStore2Context mem = new FStore2Context();
                Members = mem.Members.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return Members;

        }
        //----------------------------------------------------------------
        public Member GetMemberByID(int memberID)
        {
            List<Member> MemberList = GetMemberList();

            //using LINQ to Object
            Member member = MemberList.SingleOrDefault(pro => pro.MemberId == memberID);
            return member;
        }
        public List<Member> GetMemberByIDList(int memid)
        {
            List<Member> MemberList = GetMemberList();
            Member member = MemberList.SingleOrDefault(pro => pro.MemberId == memid);
            MemberList.Clear();
            MemberList.Add(member);
            return MemberList;
        }

        public Member GetMemberByName(string memberName)
        {
            List<Member> MemberList = GetMemberList();


            //using LINQ to Object
            Member member = MemberList.SingleOrDefault(pro => pro.CompanyName.ToUpper() == memberName.ToUpper());
            return member;
        }
        //-----------------------------------------------------------------
        //Add a new member
        public void AddNew(Member member)
        {
            try
            {
                using FStore2Context mem = new FStore2Context();
                mem.Members.Add(member);
                mem.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //Update a member
        public void Update(Member member)
        {
            try
            {
                using FStore2Context mem = new FStore2Context();
                mem.Entry<Member>(member).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                mem.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //------------------------------------------------------------------
        //Remove a member
        public void Remove(int MemberID)
        {
            try
            {
                using FStore2Context mem = new FStore2Context();
                var e = mem.Members.SingleOrDefault(m => m.MemberId == MemberID);
                mem.Members.Remove(e);
                mem.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<Member> GetMemberByCityAndCountry(string city, string country)
        {
            List<Member> FList = new List<Member>();
            List<Member> MemberList = GetMemberList();

            city = (city.ToLower() != "all city" && city.ToLower() != "city") ? city : null;
            country = (country.ToLower() != "all country" && country.ToLower() != "country") ? country : null;

            if (country != null)
                MemberList = MemberList.Where(m => m.Country.ToLower().Contains(country.ToLower())).ToList();
            if (city != null)
                MemberList = MemberList.Where(m => m.City.ToLower().Contains(city.ToLower())).ToList();

            return MemberList;
        }
    }
}
