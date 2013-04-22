namespace LibGit2Sharp
{
    internal class AttachedHead : Branch
    {
        internal AttachedHead(Repository repo, Reference reference)
            : base(repo, reference)
        {
        }
    }
}