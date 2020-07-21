using EnvDTE;
using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VueProjectWizard
{
    public class WizardImplementation : IWizard
    {
        private CustomFieldForm customFieldForm;
        //private string customField;

        public void BeforeOpeningFile(ProjectItem projectItem)
        {

        }

        public void ProjectFinishedGenerating(Project project)
        {

        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {

        }

        public void RunFinished()
        {

        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            try
            {
                var _dte = automationObject as DTE;

                customFieldForm = new CustomFieldForm();
                customFieldForm.ShowDialog();



                //customField = customFieldForm.Result;

                ////添加自定义参数 
                //replacementsDictionary.Add("customField", customField);

                _dte.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //throw new WizardBackoutException();
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }

}
