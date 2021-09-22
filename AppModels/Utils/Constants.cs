using System.Drawing;
namespace Portofolio.AppModels.Utils
{
    public class Constants
    {
        public static Size ProjectImageSize { get => new Size(1024, 1024); }

        public static Size UserImageSize { get => new Size(475, 475); }

        public static string ContactUpdateAction { get => "Contact status updated"; }

        public static string ProjectCreateAction { get => "Project created"; }

        public static string ProjectUpdateAction { get => "Project updated"; }

        public static string ProjectDeleteAction { get => "Project deleted"; }

        public static string ProjectImageDeleteAction { get => "Project image deleted"; }

        public static string ProjectUipDeleteAction { get => "User in project deleted"; }

        public static string ServiceCreateAction { get => "Service created"; }

        public static string ServiceDeleteAction { get => "Service deleted"; }

        public static string ServiceUpdateAction { get => "Service updated"; }

        public static string ContactDeleteAction { get => "Contact deleted"; }

    }

}