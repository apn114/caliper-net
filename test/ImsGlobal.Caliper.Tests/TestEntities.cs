﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Entities;
	using ImsGlobal.Caliper.Entities.Agent;
	using ImsGlobal.Caliper.Entities.Assessment;
	using ImsGlobal.Caliper.Entities.Assignable;
	using ImsGlobal.Caliper.Entities.Lis;
	using ImsGlobal.Caliper.Entities.Media;
	using ImsGlobal.Caliper.Entities.Outcome;
	using ImsGlobal.Caliper.Entities.Reading;
	using ImsGlobal.Caliper.Entities.Session;
	using ImsGlobal.Caliper.Entities.W3c;

	internal static class TestEntities {

		public static readonly string Student554433_Id = "https://some-university.edu/user/554433";
		public static readonly string AmRev101_CourseOffering_Id = "https://some-university.edu/politicalScience/2015/american-revolution-101";
		public static readonly string AmRev101_CourseSection001_Id = "https://some-university.edu/politicalScience/2015/american-revolution-101/section/001";
		public static readonly string AmRev101_Group001_Id = "https://some-university.edu/politicalScience/2015/american-revolution-101/section/001/group/001";

		public static SoftwareApplication Readium = new SoftwareApplication( "https://github.com/readium/readium-js-viewer" ) {
			Name = "Readium",
			DateCreated = 1402965614516L,
			DateModified = 1402965614516L
		};

		public static readonly IMembership Student554433_AmRev101_CourseOffering_Membership =
			new Membership( "https://some-university.edu/membership/001" ) {
				MemberId = Student554433_Id,
				OrganizationId = AmRev101_CourseOffering_Id,
				Roles = new IRole[] { Role.Learner },
				Status = Status.Active,
				DateCreated = 1402965614516L
			};
		public static readonly IMembership Student554433_AmRev101_CourseSection001_Membership =
			new Membership( "https://some-university.edu/membership/002" ) {
				MemberId = Student554433_Id,
				OrganizationId = AmRev101_CourseSection001_Id,
				Roles = new IRole[] { Role.Learner },
				Status = Status.Active,
				DateCreated = 1402965614516L
			};
		public static readonly IMembership Student554433_AmRev101_Group001_Membership =
			new Membership( "https://some-university.edu/membership/003" ) {
				MemberId = Student554433_Id,
				OrganizationId = AmRev101_Group001_Id,
				Roles = new IRole[] { Role.Learner },
				Status = Status.Active,
				DateCreated = 1402965614516L
			};

		public static IList<IMembership> Student554433_Memberships = new IMembership[] {
			Student554433_AmRev101_CourseOffering_Membership,
			Student554433_AmRev101_CourseSection001_Membership,
			Student554433_AmRev101_Group001_Membership
		};

		public static Person Student554433 = new Person( Student554433_Id ) {
			Memberships = Student554433_Memberships,
			DateCreated = 1402965614516L,
			DateModified = 1402965614516L
		};

		public static CourseOffering AmRev101_CourseOffering = new CourseOffering( AmRev101_CourseOffering_Id ) {
			CourseNumber = "POL101",
			Name = "Political Science 101: The American Revolution",
			AcademicSession = "Fall-2015",
			DateCreated = 1402965614516L,
			DateModified = 1402965614516L
		};

		public static CourseSection AmRev101_CourseSection001 = new CourseSection( AmRev101_CourseSection001_Id ) {
			CourseNumber = "POL101",
			Name = "American Revolution 101",
			AcademicSession = "Fall-2015",
			Membership = new IMembership[] { Student554433_AmRev101_CourseSection001_Membership },
			SubOrganizationOf = AmRev101_CourseOffering,
			DateCreated = 1402965614516L,
			DateModified = 1402965614516L
		};

		public static Group AmRev101_Group001 = new Group( AmRev101_Group001_Id ) {
			Name = "Discussion Group 001",
			Membership = new IMembership[] { Student554433_AmRev101_Group001_Membership },
			SubOrganizationOf = AmRev101_CourseSection001,
			DateCreated = 1402965614516L
		};

		public static WebPage AmRev101LandingPage = new WebPage( "AmRev-101-landingPage" ) {
			Name = "American Revolution 101 Landing Page",
			IsPartOf = AmRev101_CourseOffering,
			DateModified = 1402965614516L
		};

		public static EPubVolume EpubVolume43 = new EPubVolume( "https://github.com/readium/readium-js-viewer/book/34843#epubcfi(/4/3)" ) {
			Name = "The Glorious Cause: The American Revolution, 1763-1789 (Oxford History of the United States)",
			DateModified = 1402965614516L
		};

		public static EPubSubChapter EpubSubChap431 = new EPubSubChapter( "https://github.com/readium/readium-js-viewer/book/34843#epubcfi(/4/3/1)" ) {
			Name = "Key Figures: George Washington",
			IsPartOf = EpubVolume43,
			DateModified = 1402965614516L
		};

		public static Frame EpubSubChap431_Frame = new Frame( EpubSubChap431.Id ) {
			Name = EpubSubChap431.Name,
			IsPartOf = EpubVolume43,
			Index = 1,
			DateModified = 1402965614516L
		};

		public static EPubSubChapter EpubSubChap432 = new EPubSubChapter( "https://github.com/readium/readium-js-viewer/book/34843#epubcfi(/4/3/2)" ) {
			Name = "Key Figures: Lord North",
			IsPartOf = EpubVolume43,
			DateModified = 1402965614516L
		};

		public static Frame EpubSubChap432_Frame = new Frame( EpubSubChap432.Id ) {
			Name = EpubSubChap432.Name,
			IsPartOf = EpubVolume43,
			Index = 2,
			DateModified = 1402965614516L
		};

		public static EPubSubChapter EpubSubChap433 = new EPubSubChapter( "https://github.com/readium/readium-js-viewer/book/34843#epubcfi(/4/3/3)" ) {
			Name = "Key Figures: John Adams",
			IsPartOf = EpubVolume43,
			DateModified = 1402965614516L
		};

		public static Frame EpubSubChap433_Frame = new Frame( EpubSubChap433.Id ) {
			Name = EpubSubChap433.Name,
			IsPartOf = EpubVolume43,
			Index = 3,
			DateModified = 1402965614516L
		};

		public static EPubSubChapter EpubSubChap434 = new EPubSubChapter( "https://github.com/readium/readium-js-viewer/book/34843#epubcfi(/4/3/4)" ) {
			Name = "The Stamp Act Crisis",
			IsPartOf = EpubVolume43,
			DateModified = 1402965614516L
		};

		public static Frame EpubSubChap434_Frame = new Frame( EpubSubChap434.Id ) {
			Name = EpubSubChap434.Name,
			IsPartOf = EpubVolume43,
			Index = 4,
			DateModified = 1402965614516L
		};

		public static SoftwareApplication SuperMediaTool = new SoftwareApplication( "https://com.sat/super-media-tool" ) {
			Name = "Super Media Tool",
			DateModified = 1402965614516L
		};

		public static VideoObject VideoWithLearningObjective = new VideoObject( "https://com.sat/super-media-tool/video/video1" ) {
			Name = "American Revolution - Key Figures Video",
			AlignedLearningObjectives = new[] { 
				new LearningObjective( "http://americanrevolution.com/personalities/learn" ) {
					DateCreated = 1402965614516L
				}
			},
			Duration = 1420,
			Version = "1.0",
			DateCreated = 1402965614516L,
			DateModified = 1402965614516L
		};

		public static MediaLocation VideoWithLearningObjective_Location710 = new MediaLocation( VideoWithLearningObjective.Id ) {
			CurrentTime = 710,
			Version = "1.0",
			DateCreated = 1402965614516L
		};

		public static SoftwareApplication SuperAssessmentTool = new SoftwareApplication( "https://com.sat/super-assessment-tool" ) {
			Name = "Super Assessment Tool",
			DateModified = 1402965614516L
		};

		private static string Assessment1_Id = "https://some-university.edu/politicalScience/2015/american-revolution-101/assessment1";

		public static Assessment Assessment1 = new Assessment( Assessment1_Id ) {
			Name = "American Revolution - Key Figures Assessment",
			IsPartOf = AmRev101_CourseOffering.Id,
			DateCreated = 1402965614516L,
			DatePublished = 1402965614516L,
			DateToActivate = 1402965614516L,
			DateToShow = 1402965614516L,
			DateToStartOn = 1402965614516L,
			DateToSubmit = 1402965614516L,
			MaxAttempts = 2,
			MaxSubmits = 2,
			MaxScore = 3.0,
			AssessmentItems = new[] {
				new AssessmentItem( "https://some-university.edu/politicalScience/2015/american-revolution-101/assessment1/item1" ) {
					Name = "Assessment Item 1",
					IsPartOf = Assessment1_Id,
					MaxAttempts = 2,
					MaxSubmits = 2,
					MaxScore = 1.0
				},
				new AssessmentItem( "https://some-university.edu/politicalScience/2015/american-revolution-101/assessment1/item2" ) {
					Name = "Assessment Item 2",
					IsPartOf = Assessment1_Id,
					MaxAttempts = 2,
					MaxSubmits = 2,
					MaxScore = 1.0
				},
				new AssessmentItem( "https://some-university.edu/politicalScience/2015/american-revolution-101/assessment1/item3" ) {
					Name = "Assessment Item 3",
					IsPartOf = Assessment1_Id,
					MaxAttempts = 2,
					MaxSubmits = 2,
					MaxScore = 1.0
				}
			},
			DateModified = 1402965614516L
		};

		public static Attempt Assessment1_Attempt1 = new Attempt( Assessment1_Id + "/attempt1" ) {
			Assignable = Assessment1,
			Actor = Student554433,
			Count = 1
		};

		public static Result Assessment1_Attempt1_Result = new Result( Assessment1_Attempt1.Id + "/result" ) {
			NormalScore = 3.0,
			PenaltyScore = 0.0,
			ExtraCreditScore = 0.0,
			TotalScore = 3.0,
			CurvedTotalScore = 3.0,
			CurveFactor = 0.0,
			Comment = "Well done.",
		//	ScoredBy = SuperAssessmentTool,
			DateModified = 1402965614516L
		};

		public static Session SessionStart = new Session( "https://github.com/readium/session-123456789" ) {
			Name = "session-123456789",
			Actor = Student554433,
			DateModified = 1402965614516L,
			StartedAt = 1402965614516L
		};

		public static Session SessionEnd = new Session( "https://github.com/readium/session-123456789" ) {
			Name = "session-123456789",
			Actor = Student554433,
			DateModified = 1402965614516L,
			StartedAt = 1402965614516L,
			EndedAt = 1402965614516L
		};

	}

}
