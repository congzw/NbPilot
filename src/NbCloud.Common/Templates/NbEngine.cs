using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using RazorEngine;
using RazorEngine.Templating;

namespace NbCloud.Common.Templates
{
    /// <summary>
    /// 模板引擎
    /// </summary>
    public static class NbEngine
    {
        private static INbRazorEngineService _razor = new NbRazorNbRazorEngineService();
        /// <summary>
        /// 默认的模板引擎服务：Razor
        /// </summary>
        public static INbRazorEngineService Razor
        {
            get { return _razor; }
            set { _razor = value; }
        }
    }

    /// <summary>
    /// 模板引擎服务：Razor
    /// </summary>
    public interface INbRazorEngineService
    {
        /// <summary>
        /// 渲染模板内容
        /// </summary>
        /// <param name="template"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        string Render(string template, object model = null);
        /// <summary>
        /// 渲染模板文件
        /// </summary>
        /// <param name="templateFile"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        string RenderFile(string templateFile, object model = null);
    }

    /// <summary>
    /// 模板引擎服务：Razor
    /// </summary>
    public class NbRazorNbRazorEngineService : INbRazorEngineService
    {
        /// <summary>
        /// 渲染模板内容
        /// </summary>
        /// <param name="template"></param>
        /// <param name="model"></param>
        /// <returns></returns>

        public string Render(string template, object model = null)
        {
            if (string.IsNullOrWhiteSpace(template))
            {
                throw new ArgumentNullException(template);
            }

            string templateKey = CreateHashKey(template);
            return RenderContent(templateKey, template, model);
        }

        /// <summary>
        /// 渲染模板文件
        /// </summary>
        /// <param name="templateFile"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public string RenderFile(string templateFile, object model = null)
        {
            if (string.IsNullOrWhiteSpace(templateFile))
            {
                throw new ArgumentNullException("templateFile");
            }

            var isRazorFile = templateFile.EndsWith(".cshtml", StringComparison.OrdinalIgnoreCase);
            if (!isRazorFile)
            {
                throw new ArgumentException("非法的模板路径：" + templateFile);
            }

            string templateKey = templateFile.ToLower();
            var template = File.ReadAllText(templateFile);
            return RenderContent(templateKey, template, model);
        }

        #region helpers


        private string RenderContent(string templateKey, string templateContent, object model = null)
        {
            if (string.IsNullOrWhiteSpace(templateKey))
            {
                throw new ArgumentNullException("templateKey");
            }

            if (string.IsNullOrWhiteSpace(templateContent))
            {
                throw new ArgumentNullException("templateContent");
            }

            if (!CacheDic.ContainsKey(templateKey))
            {
                CacheDic[templateKey] = templateContent;
            }

            try
            {
                var result = Engine.Razor.RunCompile(templateContent, templateKey, null, model, null);
                return result;

            }
            catch (Exception ex)
            {
                LogMessage(ex.Message);
                string appendMessage = templateKey.StartsWith("Hash:") ? templateContent : templateKey;
                throw new Exception("模板编译出错：" + appendMessage, ex);
            }
        }

        private string CreateHashKey(string templateContent)
        {
            return "Hash:" + templateContent.GetHashCode();
        }

        private void LogMessage(string message)
        {
            Console.WriteLine(message);
        }

        public IDictionary<string, string> CacheDic = new ConcurrentDictionary<string, string>();

        #endregion
    }
}
