﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TelerikAcademy.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class TelerikAcademyEntities : DbContext
    {
        public TelerikAcademyEntities()
            : base("name=TelerikAcademyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeesProject> EmployeesProjects { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkHour> WorkHours { get; set; }
        public DbSet<WorkHoursLog> WorkHoursLogs { get; set; }
        public DbSet<UsersLoggedToday> UsersLoggedTodays { get; set; }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int usp_CalculateInterestSum(Nullable<decimal> sum, Nullable<int> interest, Nullable<int> months)
        {
            var sumParameter = sum.HasValue ?
                new ObjectParameter("Sum", sum) :
                new ObjectParameter("Sum", typeof(decimal));
    
            var interestParameter = interest.HasValue ?
                new ObjectParameter("Interest", interest) :
                new ObjectParameter("Interest", typeof(int));
    
            var monthsParameter = months.HasValue ?
                new ObjectParameter("Months", months) :
                new ObjectParameter("Months", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_CalculateInterestSum", sumParameter, interestParameter, monthsParameter);
        }
    
        public virtual int usp_CalculateMonthlyInterest(Nullable<int> accountId, Nullable<int> interest)
        {
            var accountIdParameter = accountId.HasValue ?
                new ObjectParameter("AccountId", accountId) :
                new ObjectParameter("AccountId", typeof(int));
    
            var interestParameter = interest.HasValue ?
                new ObjectParameter("Interest", interest) :
                new ObjectParameter("Interest", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_CalculateMonthlyInterest", accountIdParameter, interestParameter);
        }
    
        public virtual int usp_CalculateNewSum(Nullable<int> sum, Nullable<int> interest, Nullable<int> months, ObjectParameter result)
        {
            var sumParameter = sum.HasValue ?
                new ObjectParameter("Sum", sum) :
                new ObjectParameter("Sum", typeof(int));
    
            var interestParameter = interest.HasValue ?
                new ObjectParameter("Interest", interest) :
                new ObjectParameter("Interest", typeof(int));
    
            var monthsParameter = months.HasValue ?
                new ObjectParameter("Months", months) :
                new ObjectParameter("Months", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_CalculateNewSum", sumParameter, interestParameter, monthsParameter, result);
        }
    
        public virtual int usp_DepositMoney(Nullable<int> accountId, Nullable<decimal> money)
        {
            var accountIdParameter = accountId.HasValue ?
                new ObjectParameter("AccountId", accountId) :
                new ObjectParameter("AccountId", typeof(int));
    
            var moneyParameter = money.HasValue ?
                new ObjectParameter("Money", money) :
                new ObjectParameter("Money", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_DepositMoney", accountIdParameter, moneyParameter);
        }
    
        public virtual int usp_FindLastNames(string lettersToSearch)
        {
            var lettersToSearchParameter = lettersToSearch != null ?
                new ObjectParameter("lettersToSearch", lettersToSearch) :
                new ObjectParameter("lettersToSearch", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_FindLastNames", lettersToSearchParameter);
        }
    
        public virtual int usp_FindMiddleNames(string lettersToSearch)
        {
            var lettersToSearchParameter = lettersToSearch != null ?
                new ObjectParameter("lettersToSearch", lettersToSearch) :
                new ObjectParameter("lettersToSearch", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_FindMiddleNames", lettersToSearchParameter);
        }
    
        public virtual int usp_GiveInterest(Nullable<int> id, Nullable<int> interest, ObjectParameter rESULT)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var interestParameter = interest.HasValue ?
                new ObjectParameter("interest", interest) :
                new ObjectParameter("interest", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_GiveInterest", idParameter, interestParameter, rESULT);
        }
    
        public virtual ObjectResult<usp_SelectPersonsBallanceGreaterThan_Result> usp_SelectPersonsBallanceGreaterThan(Nullable<int> referenceBalance)
        {
            var referenceBalanceParameter = referenceBalance.HasValue ?
                new ObjectParameter("referenceBalance", referenceBalance) :
                new ObjectParameter("referenceBalance", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_SelectPersonsBallanceGreaterThan_Result>("usp_SelectPersonsBallanceGreaterThan", referenceBalanceParameter);
        }
    
        public virtual ObjectResult<string> usp_SelectPersonsFullNames()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("usp_SelectPersonsFullNames");
        }
    
        public virtual int usp_WithdrawMoney(Nullable<int> accountId, Nullable<decimal> money)
        {
            var accountIdParameter = accountId.HasValue ?
                new ObjectParameter("AccountId", accountId) :
                new ObjectParameter("AccountId", typeof(int));
    
            var moneyParameter = money.HasValue ?
                new ObjectParameter("Money", money) :
                new ObjectParameter("Money", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_WithdrawMoney", accountIdParameter, moneyParameter);
        }
    }
}