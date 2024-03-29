namespace JabbR.Models.Migrations
{
    using System.Data.Entity.Migrations.Infrastructure;
    
    public partial class UserStatus : IMigrationMetadata
    {
        string IMigrationMetadata.Id
        {
            get { return "201111251652132_UserStatus"; }
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
