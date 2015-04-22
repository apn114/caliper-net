﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;
using Xunit;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Tests.SimpleHelpers;
	using ImsGlobal.Caliper.Events;
	using ImsGlobal.Caliper.Events.Assessment;

	public class AssessmentEventsTests {

		[Fact]
		public void AssessmentEvent_MatchesReferenceJson() {

			var assessmentEvent = new AssessmentEvent( Action.Started ) {
				EdApp = TestEntities.SuperAssessmentTool,
				Group = TestEntities.AmRev101_CourseOffering,
				Actor = TestEntities.Student554433,
				Object = TestEntities.Assessment1,
				Generated = TestEntities.Assessment1_Attempt1,
				StartedAt = TestEntities.DefaultStartedAtTime
			};

			var eventJson = JObject.FromObject( assessmentEvent );
			var refJsonString = TestUtils.LoadReferenceJsonFile( "caliperAssessmentEvent" );
			var refJson = JObject.Parse( refJsonString );

			var diff = ObjectDiffPatch.GenerateDiff( refJson, eventJson );

			System.Diagnostics.Trace.WriteLine( diff.NewValues );
			System.Diagnostics.Trace.WriteLine( diff.OldValues );

			Assert.Null( diff.NewValues );
			Assert.Null( diff.OldValues );
		}

	}

}
