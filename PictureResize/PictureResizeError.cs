using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PictureResize
{
    public class PictureResizeError
    {
        public enum PRErrorType
        {
            FileNotFound,
            FileNotOpenable,
            NoWidthHeightEntered,
            ResizeError,
            SaveError,
            None,
            Other
        }

        private PRErrorType _type;
        private string[] _additionalInfos;

        public PictureResizeError(PRErrorType type, params string[] additionalInfos)
        {
            _type = type;
            _additionalInfos = additionalInfos;
        }

        public PictureResizeError(PRErrorType type)
        {
            _type = type;
        }

        public PRErrorType Type
        {
            get
            {
                return _type;
            }
        }
        public string[] AdditionalInfos
        {
            get
            {
                return _additionalInfos;
            }
        }

        public string GetErrorMessage(IErrorsLanguage language)
        {
            string message;
            switch (Type)
            {
                case PRErrorType.FileNotFound:
                    message = language.FileNotFound;
                    break;
                case PRErrorType.FileNotOpenable:
                    message = language.FileNotOpenable;
                    break;
                case PRErrorType.NoWidthHeightEntered:
                    message = language.NoWidthHeightEntered;
                    break;
                case PRErrorType.ResizeError:
                    message = language.ResizeError;
                    break;
                case PRErrorType.SaveError:
                    message = language.SaveError;
                    break;
                case PRErrorType.None:
                    return "";
                default:
                    message = language.OtherError;
                    break;
            }
            return StringPlaceholderReplacer.Replace(message, _additionalInfos);
        }
    }
}
