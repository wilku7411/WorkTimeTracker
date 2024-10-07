using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WorkTimeTracker
{
	

	[System.Serializable]
	internal class WorkTrackerEvent
	{
		private string Title;
		private string Description;
		private string InterruptedJob;
		private HashSet<string> Tags;
		private TimeSpan TimeStamp;

        public WorkTrackerEvent()
        {
            Title = string.Empty; 
			Description = string.Empty;
			InterruptedJob = string.Empty;
			Tags = new HashSet<string>();
			TimeStamp = TimeSpan.Zero;
        }

		public WorkTrackerEvent(string title, string description, string interruptedJob, List<string> tags, TimeSpan timeStamp)
		{
			Title = title;
			Description = description;
			InterruptedJob = interruptedJob;
			Tags = tags.ToHashSet();
			TimeStamp = timeStamp;
		}

		public List<string> GetTagsList()
		{
			return Tags.ToList();
		}
    }

	[System.Serializable]
	internal class DayEvents
	{
		static private string RecordedEvetsFilePath = Application.StartupPath;
		static private string EventsFileName = @"\Events.wtt";

		private Dictionary<DateTime, List<WorkTrackerEvent>> Events;
		private List<string> CachedTags;

		public DayEvents()
		{
			Events = new Dictionary<DateTime, List<WorkTrackerEvent>>();
			CachedTags = new List<string>();
		}

		public void AddEvent(WorkTrackerEvent WorkEvent)
		{
			var Today = DateTime.Today;
			if (Events.ContainsKey(Today))
			{
				Events[Today].Add(WorkEvent);
			}
			else
			{
				Events.Add(Today, new List<WorkTrackerEvent>() { WorkEvent });
			}
			CachedTags.AddRange(WorkEvent.GetTagsList());
		}

		public List<WorkTrackerEvent> GetEventsFromDay(DateTime Day) 
		{
			if(Events.ContainsKey(Day))
			{
				return Events[Day];
			}
			return new List<WorkTrackerEvent>();
		}

		public List<string> GetAllCachedTags()
		{
			return CachedTags;
		}

		public bool DoesEventFileExist()
		{
			return File.Exists(RecordedEvetsFilePath + EventsFileName);
		}

		static public void Serialize(ref DayEvents ObjectsSystem)
		{
			//Create the stream to add object into it.  
			Stream TagSystemStream = File.OpenWrite(RecordedEvetsFilePath + EventsFileName);

			//Format the object as Binary  
			BinaryFormatter Formatter = new BinaryFormatter();

			Formatter.Serialize(TagSystemStream, ObjectsSystem);
			TagSystemStream.Flush();
			TagSystemStream.Close();
			TagSystemStream.Dispose();
		}

		static public void Deserialize(ref DayEvents ObjectsSystem)
		{
			if (!ObjectsSystem.DoesEventFileExist())
			{
				return;
			}

			//Format the object as Binary  
			BinaryFormatter Formatter = new BinaryFormatter();

			//Reading the file 
			FileStream TagSystemStream = File.Open(RecordedEvetsFilePath + EventsFileName, FileMode.Open);

			try
			{
				object Obj = Formatter.Deserialize(TagSystemStream);
				ObjectsSystem = (DayEvents)Obj;
				TagSystemStream.Flush();
				TagSystemStream.Close();
				TagSystemStream.Dispose();
			}
			catch (Exception)
			{
				TagSystemStream.Flush();
				TagSystemStream.Close();
				TagSystemStream.Dispose();
				return;
			}
			

		}
	}
}
