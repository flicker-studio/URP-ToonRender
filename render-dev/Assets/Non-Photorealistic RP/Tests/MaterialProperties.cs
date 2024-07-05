using UnityEngine;

namespace Non_Photorealistic_RP.Tests
{
    /// <summary>
    ///     GPU instantiation test component
    /// </summary>
    [DisallowMultipleComponent]
    public class MaterialProperties : MonoBehaviour
    {
        private static readonly int BaseColorId = Shader.PropertyToID("_BaseColor");

        private static MaterialPropertyBlock _block;

        [SerializeField] private Color baseColor = Color.white;

        private void Awake()
        {
            baseColor = new Color(Random.value, Random.value, Random.value, 0.5f);
            OnValidate();
        }

        private void OnValidate()
        {
            _block ??= new MaterialPropertyBlock();
            _block.SetColor(BaseColorId, baseColor);
            GetComponent<Renderer>().SetPropertyBlock(_block);
        }
    }
}