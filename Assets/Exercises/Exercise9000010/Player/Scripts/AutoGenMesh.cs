using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGenMesh : MonoBehaviour
{
    public float _plane_half_wid = 10f;
    public float _plane_half_hei = 10f;
    public bool _mode = true;

    private MeshFilter _mesh_filter;
    private MeshRenderer _mesh_renderer;
    private Mesh _mesh;

    void Awake()
    {
        _mesh_filter = this.GetComponent<MeshFilter>();
        _mesh_renderer = this.GetComponent<MeshRenderer>();

        _mesh_renderer.material.SetFloat("_mode", _mode ? 0 : 1);
        _mesh_renderer.material.SetFloat("_planeWid", _plane_half_wid * 2);
        _mesh_renderer.material.SetFloat("_planeHei", _plane_half_hei * 2);

        List<Vector3> vertices = new List<Vector3>();
        vertices.Add(new Vector3(-_plane_half_wid, -_plane_half_hei, 0));
        vertices.Add(new Vector3(-_plane_half_wid, _plane_half_hei, 0));
        vertices.Add(new Vector3(_plane_half_wid, _plane_half_hei, 0));
        vertices.Add(new Vector3(_plane_half_wid, -_plane_half_hei, 0));

        List<Vector2> uvs = new List<Vector2>();
        uvs.Add(new Vector2(0, 0));
        uvs.Add(new Vector2(0, 1));
        uvs.Add(new Vector2(1, 1));
        uvs.Add(new Vector2(1, 0));

        List<int> triangles = new List<int>();
        triangles.Add(0);
        triangles.Add(1);
        triangles.Add(2);
        triangles.Add(0);
        triangles.Add(2);
        triangles.Add(3);

        _mesh = new Mesh();
        _mesh.name = "Grid";
        _mesh.SetVertices(vertices);
        _mesh.SetUVs(0, uvs);
        _mesh.SetTriangles(triangles, 0);

        _mesh_filter.mesh = _mesh;
    }
    void Start()
    {
    }

    void Update()
    {
    }
}
