using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VueProjectWizard
{
    public class WizardImplementation : IWizard
    {
        //private DTE _dte = null;
        //private string _solutionDir = null;
        //private string _projectName = null;
        //private string _templateDir = null;

        //private CustomFieldForm customFieldForm;
        //private string customField;

        /// <summary>
        /// 打开文件之前（项目项）
        /// 在模板中打开项目之前运行自定义向导逻辑
        /// </summary>
        /// <param name="projectItem"></param>
        public void BeforeOpeningFile(ProjectItem projectItem)
        {

        }
        /// <summary>
        /// 项目完成生成（项目）
        /// 项目完成生成后运行自定义向导逻辑。
        /// </summary>
        /// <param name="project"></param>
        public void ProjectFinishedGenerating(Project project)
        {
            ////MessageBox.Show("ssssss");
            ////var platform = "test";
            ////string name = $"{_projectName}.{platform}";
            ////string projectPath = System.IO.Path.Combine(_solutionDir, Path.Combine(_projectName, name));
            //string projectPath = System.IO.Path.Combine(_solutionDir, _projectName);
            ////string templateName = $"Prism.Forms.Plugin.{platform}";
            ////string templatePath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(_templateDir), $"{templateName}.zip\\{templateName}.vstemplate");
            //string templatePath = System.IO.Path.Combine(_templateDir, "VueCliTemplate.vstemplate");
            ////_dte.Solution.AddFromTemplate(templatePath, projectPath, "fffffffffffffff");

            ////project.ProjectItems.AddFolder(templatePath, project.Name);




        }
        /// <summary>
        /// 项目项目完成生成（项目项目）
        /// 项目项目完成生成后，运行自定义向导逻辑。
        /// </summary>
        /// <param name="projectItem"></param>
        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {

        }
        /// <summary>
        /// 向导完成所有任务后，运行自定义向导逻辑。
        /// </summary>
        public void RunFinished()
        {

        }
        /// <summary>
        /// 在模板向导运行开始时运行自定义向导逻辑。
        /// </summary>
        /// <param name="automationObject"></param>
        /// <param name="replacementsDictionary"></param>
        /// <param name="runKind"></param>
        /// <param name="customParams"></param>
        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            try
            {
                //MessageBox.Show("eeeeee");
                //var OleServiceProvider = (automationObject as IServiceProvider);
                //var dddd = OleServiceProvider.GetService(typeof(DTE));

                //_dte = automationObject as DTE;
                //_projectName = replacementsDictionary["$safeprojectname$"];
                //_solutionDir = System.IO.Path.GetDirectoryName(replacementsDictionary["$destinationdirectory$"]);
                //_templateDir = System.IO.Path.GetDirectoryName(customParams[0] as string);


                //customFieldForm = new CustomFieldForm();
                //customFieldForm.ShowDialog();



                //customField = customFieldForm.Result;

                ////添加自定义参数 
                //replacementsDictionary.Add("customField", customField);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //throw new WizardBackoutException();
        }
        /// <summary>
        /// 指示是否应将指定的项目项添加到项目中。
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public bool ShouldAddProjectItem(string filePath)
        {
            //return filePath.StartsWith("Template\\VueJsForBootstrapTemplate\\", StringComparison.OrdinalIgnoreCase) ? false : true;
            return true;
        }
    }

}
