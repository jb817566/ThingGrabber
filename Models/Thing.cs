namespace ThingGrabber.Models
{
    public class Thing
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfFiles { get; set; }

        //Relationships
        public long? ThingMetadataID { get; set; } //ThingMetadata.cs

        public long? PrintSettingsID { get; set; } //PrintSettings.cs
    }
}