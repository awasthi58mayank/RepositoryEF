﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityDL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ProjectEntities : DbContext
    {
        public ProjectEntities()
            : base("name=ProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Batch> Batches { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Grader> Graders { get; set; }
    
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
    
        public virtual int sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
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
    
        public virtual int uspInsertBatch(string batchID, string batchName, Nullable<int> batchStrength)
        {
            var batchIDParameter = batchID != null ?
                new ObjectParameter("BatchID", batchID) :
                new ObjectParameter("BatchID", typeof(string));
    
            var batchNameParameter = batchName != null ?
                new ObjectParameter("BatchName", batchName) :
                new ObjectParameter("BatchName", typeof(string));
    
            var batchStrengthParameter = batchStrength.HasValue ?
                new ObjectParameter("BatchStrength", batchStrength) :
                new ObjectParameter("BatchStrength", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspInsertBatch", batchIDParameter, batchNameParameter, batchStrengthParameter);
        }
    
        public virtual int uspInsertBatchFacultyMapping(string batchID, Nullable<int> pSNo)
        {
            var batchIDParameter = batchID != null ?
                new ObjectParameter("BatchID", batchID) :
                new ObjectParameter("BatchID", typeof(string));
    
            var pSNoParameter = pSNo.HasValue ?
                new ObjectParameter("PSNo", pSNo) :
                new ObjectParameter("PSNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspInsertBatchFacultyMapping", batchIDParameter, pSNoParameter);
        }
    
        public virtual int uspInsertBatchModelMapping(string batchID, Nullable<int> modelID)
        {
            var batchIDParameter = batchID != null ?
                new ObjectParameter("BatchID", batchID) :
                new ObjectParameter("BatchID", typeof(string));
    
            var modelIDParameter = modelID.HasValue ?
                new ObjectParameter("ModelID", modelID) :
                new ObjectParameter("ModelID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspInsertBatchModelMapping", batchIDParameter, modelIDParameter);
        }
    
        public virtual int uspInsertCourse_BatchMapping(string courseID, string batchID)
        {
            var courseIDParameter = courseID != null ?
                new ObjectParameter("CourseID", courseID) :
                new ObjectParameter("CourseID", typeof(string));
    
            var batchIDParameter = batchID != null ?
                new ObjectParameter("BatchID", batchID) :
                new ObjectParameter("BatchID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspInsertCourse_BatchMapping", courseIDParameter, batchIDParameter);
        }
    
        public virtual int uspInsertCourseDetails(string courseId, string courseTitle, Nullable<int> duration, string owner, string assessmentMode)
        {
            var courseIdParameter = courseId != null ?
                new ObjectParameter("CourseId", courseId) :
                new ObjectParameter("CourseId", typeof(string));
    
            var courseTitleParameter = courseTitle != null ?
                new ObjectParameter("CourseTitle", courseTitle) :
                new ObjectParameter("CourseTitle", typeof(string));
    
            var durationParameter = duration.HasValue ?
                new ObjectParameter("Duration", duration) :
                new ObjectParameter("Duration", typeof(int));
    
            var ownerParameter = owner != null ?
                new ObjectParameter("Owner", owner) :
                new ObjectParameter("Owner", typeof(string));
    
            var assessmentModeParameter = assessmentMode != null ?
                new ObjectParameter("AssessmentMode", assessmentMode) :
                new ObjectParameter("AssessmentMode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspInsertCourseDetails", courseIdParameter, courseTitleParameter, durationParameter, ownerParameter, assessmentModeParameter);
        }
    
        public virtual int uspInsertFacultyDetails(string name, string email, Nullable<int> psno)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var psnoParameter = psno.HasValue ?
                new ObjectParameter("psno", psno) :
                new ObjectParameter("psno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspInsertFacultyDetails", nameParameter, emailParameter, psnoParameter);
        }
    
        public virtual int uspInsertGrader(Nullable<int> marks_Obtain, string feedback, string batchID, string courseID, Nullable<int> participantID)
        {
            var marks_ObtainParameter = marks_Obtain.HasValue ?
                new ObjectParameter("Marks_Obtain", marks_Obtain) :
                new ObjectParameter("Marks_Obtain", typeof(int));
    
            var feedbackParameter = feedback != null ?
                new ObjectParameter("Feedback", feedback) :
                new ObjectParameter("Feedback", typeof(string));
    
            var batchIDParameter = batchID != null ?
                new ObjectParameter("BatchID", batchID) :
                new ObjectParameter("BatchID", typeof(string));
    
            var courseIDParameter = courseID != null ?
                new ObjectParameter("CourseID", courseID) :
                new ObjectParameter("CourseID", typeof(string));
    
            var participantIDParameter = participantID.HasValue ?
                new ObjectParameter("ParticipantID", participantID) :
                new ObjectParameter("ParticipantID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspInsertGrader", marks_ObtainParameter, feedbackParameter, batchIDParameter, courseIDParameter, participantIDParameter);
        }
    
        public virtual int uspInsertModelDetails(Nullable<int> mid, string mname, string mowner, Nullable<System.DateTime> mdate)
        {
            var midParameter = mid.HasValue ?
                new ObjectParameter("Mid", mid) :
                new ObjectParameter("Mid", typeof(int));
    
            var mnameParameter = mname != null ?
                new ObjectParameter("Mname", mname) :
                new ObjectParameter("Mname", typeof(string));
    
            var mownerParameter = mowner != null ?
                new ObjectParameter("Mowner", mowner) :
                new ObjectParameter("Mowner", typeof(string));
    
            var mdateParameter = mdate.HasValue ?
                new ObjectParameter("Mdate", mdate) :
                new ObjectParameter("Mdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspInsertModelDetails", midParameter, mnameParameter, mownerParameter, mdateParameter);
        }
    
        public virtual int uspInsertParticipants(Nullable<int> participantID, string participantName, string participantEmailID)
        {
            var participantIDParameter = participantID.HasValue ?
                new ObjectParameter("ParticipantID", participantID) :
                new ObjectParameter("ParticipantID", typeof(int));
    
            var participantNameParameter = participantName != null ?
                new ObjectParameter("ParticipantName", participantName) :
                new ObjectParameter("ParticipantName", typeof(string));
    
            var participantEmailIDParameter = participantEmailID != null ?
                new ObjectParameter("ParticipantEmailID", participantEmailID) :
                new ObjectParameter("ParticipantEmailID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspInsertParticipants", participantIDParameter, participantNameParameter, participantEmailIDParameter);
        }
    
        public virtual int uspInsertParticitpantBatchMapping(string batchID, Nullable<int> participantID)
        {
            var batchIDParameter = batchID != null ?
                new ObjectParameter("BatchID", batchID) :
                new ObjectParameter("BatchID", typeof(string));
    
            var participantIDParameter = participantID.HasValue ?
                new ObjectParameter("ParticipantID", participantID) :
                new ObjectParameter("ParticipantID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspInsertParticitpantBatchMapping", batchIDParameter, participantIDParameter);
        }
    
        public virtual int uspModifyAssessmentMode(string cID, string mode)
        {
            var cIDParameter = cID != null ?
                new ObjectParameter("CID", cID) :
                new ObjectParameter("CID", typeof(string));
    
            var modeParameter = mode != null ?
                new ObjectParameter("Mode", mode) :
                new ObjectParameter("Mode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspModifyAssessmentMode", cIDParameter, modeParameter);
        }
    
        public virtual int uspModifyCourseDuration(string cID, Nullable<int> dur)
        {
            var cIDParameter = cID != null ?
                new ObjectParameter("CID", cID) :
                new ObjectParameter("CID", typeof(string));
    
            var durParameter = dur.HasValue ?
                new ObjectParameter("Dur", dur) :
                new ObjectParameter("Dur", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspModifyCourseDuration", cIDParameter, durParameter);
        }
    
        public virtual int uspModifyCourseOwner(string cID, string own)
        {
            var cIDParameter = cID != null ?
                new ObjectParameter("CID", cID) :
                new ObjectParameter("CID", typeof(string));
    
            var ownParameter = own != null ?
                new ObjectParameter("Own", own) :
                new ObjectParameter("Own", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspModifyCourseOwner", cIDParameter, ownParameter);
        }
    
        public virtual int uspModifyGrader(Nullable<int> marks_Obtained, string feedback)
        {
            var marks_ObtainedParameter = marks_Obtained.HasValue ?
                new ObjectParameter("Marks_Obtained", marks_Obtained) :
                new ObjectParameter("Marks_Obtained", typeof(int));
    
            var feedbackParameter = feedback != null ?
                new ObjectParameter("Feedback", feedback) :
                new ObjectParameter("Feedback", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("uspModifyGrader", marks_ObtainedParameter, feedbackParameter);
        }
    }
}
