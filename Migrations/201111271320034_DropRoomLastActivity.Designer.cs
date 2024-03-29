namespace JabbR.Models.Migrations
{
    using System.Data.Entity.Migrations.Infrastructure;
    
    public partial class DropRoomLastActivity : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201111271320034_DropRoomLastActivity"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return "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"; }
        }
    }
}
