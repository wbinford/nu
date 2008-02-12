namespace nu.Model.Template
{
    using System;
    using nu.Model.Project;

    public class Generator
    {
        public Generator(IFileSystem fileSystem, IProjectManifest projectManifest/*, ITemplateProcessor templateProcessor*/)
        {
            _fileSystem = fileSystem;
            _projectManifest = projectManifest;
            //_templateProcessor = templateProcessor;
        }

        private readonly IProjectManifest _projectManifest;
        private readonly ITemplateProcessor _templateProcessor;
        private readonly IFileSystem _fileSystem;


        public IProjectManifest ProjectManifest
        {
            get { return _projectManifest; }
        }

        private IFileSystem FileSystem
        {
            get { return _fileSystem; }
        }

        public ITemplateProcessor TemplateProcessor
        {
            get { return _templateProcessor; }
        }


        public void Generate()
        {
            foreach (projectTarget target in ProjectManifest.Directories)
            {
                // need to change this to account for a user supplied directory.
                FileSystem.CreateDirectory(target.path);
            }

            //foreach (TransformationElement element in ProjectManifest.Files)
            //{
            //    // provide the template processor with extra data
            //    // e.g. base directory, etc.
            //    TemplateProcessor.Transform(element);
            //}
        }
    }
}