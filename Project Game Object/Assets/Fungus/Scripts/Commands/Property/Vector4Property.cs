/*This script has been, partially or completely, generated by the Fungus.GenerateVariableWindow*/
using UnityEngine;


namespace Fungus
{
    // <summary>
    /// Get or Set a property of a Vector4 component
    /// </summary>
    [CommandInfo("Property",
                 "Vector4",
                 "Get or Set a property of a Vector4 component")]
    [AddComponentMenu("")]
    public class Vector4Property : BaseVariableProperty
    {
		//generated property
        public enum Property 
        { 
            X, 
            Y, 
            Z, 
            W, 
            Magnitude, 
            SqrMagnitude, 
            Normalized, 
        }

		
        [SerializeField]
        protected Property property;
		
        [SerializeField]
        protected Vector4Data vector4Data;

        [SerializeField]
        [VariableProperty(typeof(FloatVariable),
                          typeof(Vector4Variable))]
        protected Variable inOutVar;

        public override void OnEnter()
        {
            var iof = inOutVar as FloatVariable;
            var iov4 = inOutVar as Vector4Variable;


            var target = vector4Data.Value;

            switch (getOrSet)
            {
                case GetSet.Get:
                    switch (property)
                    {
                        case Property.X:
                            iof.Value = target.x;
                            break;
                        case Property.Y:
                            iof.Value = target.y;
                            break;
                        case Property.Z:
                            iof.Value = target.z;
                            break;
                        case Property.W:
                            iof.Value = target.w;
                            break;
                        case Property.Normalized:
                            iov4.Value = target.normalized;
                            break;
                        case Property.Magnitude:
                            iof.Value = target.magnitude;
                            break;
                        case Property.SqrMagnitude:
                            iof.Value = target.sqrMagnitude;
                            break;
                        default:
                            Debug.Log("Unsupported get or set attempted");
                            break;
                    }

                    break;
                case GetSet.Set:
                    switch (property)
                    {
                        case Property.X:
                            target.x = iof.Value;
                            break;
                        case Property.Y:
                            target.y = iof.Value;
                            break;
                        case Property.Z:
                            target.z = iof.Value;
                            break;
                        case Property.W:
                            target.w = iof.Value;
                            break;
                        default:
                            Debug.Log("Unsupported get or set attempted");
                            break;
                    }

                    break;
                default:
                    break;
            }


            vector4Data.Value = target;

            Continue();
        }

        public override string GetSummary()
        {
            if (inOutVar == null)
            {
                return "Error: no variable set to push or pull data to or from";
            }

            return getOrSet.ToString() + " " + property.ToString();
        }

        public override Color GetButtonColor()
        {
            return new Color32(235, 191, 217, 255);
        }

        public override bool HasReference(Variable variable)
        {
            if (vector4Data.vector4Ref == variable || inOutVar == variable)
                return true;

            return false;
        }

    }
}