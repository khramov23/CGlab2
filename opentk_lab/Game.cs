using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.GraphicsLibraryFramework;
using OpenTK.Windowing.Desktop;
using opentk_lab.ObjectsImport;

namespace opentk_lab
{
    public class Game : GameWindow
    {

        private readonly Vector3[] ground_positions =
        {
            new Vector3(3f, 4f, 0f),
            new Vector3(5f, 4f, 0f),
            new Vector3(4f, 2f, 1f),
            new Vector3(4f, 2f, -6f),
            new Vector3(4f, 4f, -4f),
            new Vector3(0.0f, 2.0f, -2 - 0.0f),
            new Vector3(2.0f, 2.0f, -2 - 0.0f),
            new Vector3(4.0f, 2.0f, -2 - 0.0f),
            new Vector3(6.0f, 2.0f, -2 - 0.0f),
            new Vector3(8.0f, 2.0f, -2 - 0.0f),
            new Vector3(2.0f, 2.0f, -2 - 2.0f),
            new Vector3(4.0f, 2.0f, -2 - 2.0f),
            new Vector3(6.0f, 2.0f, -2 - 2.0f),

            new Vector3(2.0f, 4.0f, -2 - 0.0f),
            new Vector3(4.0f, 4.0f, -2 - 0.0f),
            new Vector3(6.0f, 4.0f, -2 - 0.0f),

            new Vector3(4.0f, 6.0f, -2 - 0.0f),

            
            new Vector3(2.0f, 0.0f, -2 - 0.0f),
            new Vector3(4.0f, 0.0f, -2 - 0.0f),
            new Vector3(6.0f, 0.0f, -2 - 0.0f),
            new Vector3(0.0f, 0.0f, -2 - 2.0f),
            new Vector3(2.0f, 0.0f, -2 - 2.0f),
            new Vector3(4.0f, 0.0f, -2 - 2.0f),
            new Vector3(6.0f, 0.0f, -2 - 2.0f),
            new Vector3(8.0f, 0.0f, -2 - 2.0f),
            new Vector3(0.0f, 0.0f, -4 - 2.0f),
            new Vector3(2.0f, 0.0f, -4 - 2.0f),
            new Vector3(6.0f, 0.0f, -4 - 2.0f),
            new Vector3(8.0f, 0.0f, -4 - 2.0f),

            new Vector3(0.0f, 0.0f, 0.0f),
            new Vector3(2.0f, 0.0f, 0.0f),
            new Vector3(4.0f, 0.0f, 0.0f),
            new Vector3(6.0f, 0.0f, 0.0f),
            new Vector3(8.0f, 0.0f, 0.0f),
            new Vector3(0.0f, 0.0f, 2.0f),
            new Vector3(2.0f, 0.0f, 2.0f),
            new Vector3(4.0f, 0.0f, 2.0f),
            new Vector3(6.0f, 0.0f, 2.0f),
            new Vector3(8.0f, 0.0f, 2.0f),

            new Vector3(0.0f, 0.0f, 0 + 8.0f),
            new Vector3(2.0f, 0.0f, 0 + 8.0f),
            new Vector3(4.0f, 0.0f, 0 + 8.0f),
            new Vector3(6.0f, 0.0f, 0 + 8.0f),
            new Vector3(8.0f, 0.0f, 0 + 8.0f),
            new Vector3(0.0f, 0.0f, 2 + 8.0f),
            new Vector3(2.0f, 0.0f, 2 + 8.0f),
            new Vector3(4.0f, 0.0f, 2 + 8.0f),
            new Vector3(6.0f, 0.0f, 2 + 8.0f),
            new Vector3(8.0f, 0.0f, 2 + 8.0f),
        };

        private readonly Vector3[] full_ground_positions =
        {
            new Vector3(0.0f, 0.0f, -2 - 0.0f),
            new Vector3(8.0f, 0.0f, -2 - 0.0f),
            new Vector3(4.0f, 0.0f, -4 - 2.0f),
            new Vector3(2.0f, 2.0f, 0.0f),
            new Vector3(4.0f, 2.0f, 0.0f),
            new Vector3(6.0f, 2.0f, 0.0f),

            new Vector3(0.0f,  -2.0f, -4-0.0f),
            new Vector3(2.0f,  -2.0f, -4-0.0f),
            new Vector3(4.0f,  -2.0f, -4-0.0f),
            new Vector3(6.0f,  -2.0f, -4-0.0f),
            new Vector3(8.0f,  -2.0f, -4-0.0f),
            new Vector3(0.0f,  -2.0f, -4-2.0f),
            new Vector3(2.0f,  -2.0f, -4-2.0f),
            new Vector3(4.0f,  -2.0f, -4-2.0f),
            new Vector3(6.0f,  -2.0f, -4-2.0f),
            new Vector3(8.0f,  -2.0f, -4-2.0f),
            new Vector3(0.0f,  -2.0f, -2-0.0f),
            new Vector3(2.0f,  -2.0f, -2-0.0f),
            new Vector3(4.0f,  -2.0f, -2-0.0f),
            new Vector3(6.0f,  -2.0f, -2-0.0f),
            new Vector3(8.0f,  -2.0f, -2-0.0f),
            new Vector3(0.0f,  -2.0f, -2-2.0f),
            new Vector3(2.0f,  -2.0f, -2-2.0f),
            new Vector3(4.0f,  -2.0f, -2-2.0f),
            new Vector3(6.0f,  -2.0f, -2-2.0f),
            new Vector3(8.0f,  -2.0f, -2-2.0f),
            new Vector3(0.0f,  -2.0f, 0.0f),
            new Vector3(2.0f,  -2.0f, 0.0f),
            new Vector3(4.0f,  -2.0f, 0.0f),
            new Vector3(6.0f,  -2.0f, 0.0f),
            new Vector3(8.0f,  -2.0f, 0.0f),
            new Vector3(0.0f,  -2.0f, 2.0f),
            new Vector3(2.0f,  -2.0f, 2.0f),
            new Vector3(4.0f,  -2.0f, 2.0f),
            new Vector3(6.0f,  -2.0f, 2.0f),
            new Vector3(8.0f,  -2.0f, 2.0f),

            new Vector3(0.0f,  -2.0f, 0 + 4.0f),
            new Vector3(2.0f,  -2.0f, 0 + 4.0f),
            new Vector3(4.0f,  -2.0f, 0 + 4.0f),
            new Vector3(6.0f,  -2.0f, 0 + 4.0f),
            new Vector3(8.0f,  -2.0f, 0 + 4.0f),
            new Vector3(0.0f,  -2.0f, 2 + 4.0f),
            new Vector3(2.0f,  -2.0f, 2 + 4.0f),
            new Vector3(4.0f,  -2.0f, 2 + 4.0f),
            new Vector3(6.0f,  -2.0f, 2 + 4.0f),
            new Vector3(8.0f,  -2.0f, 2 + 4.0f),

            new Vector3(0.0f,  -2.0f, 0 + 8.0f),
            new Vector3(2.0f,  -2.0f, 0 + 8.0f),
            new Vector3(4.0f,  -2.0f, 0 + 8.0f),
            new Vector3(6.0f,  -2.0f, 0 + 8.0f),
            new Vector3(8.0f,  -2.0f, 0 + 8.0f),
            new Vector3(0.0f,  -2.0f, 2 + 8.0f),
            new Vector3(2.0f,  -2.0f, 2 + 8.0f),
            new Vector3(4.0f,  -2.0f, 2 + 8.0f),
            new Vector3(6.0f,  -2.0f, 2 + 8.0f),
            new Vector3(8.0f,  -2.0f, 2 + 8.0f),
        };

        private readonly Vector3[] water_positions =
        {
            new Vector3(0.0f,  0.0f, 0 + 4.0f),
            new Vector3(2.0f,  0.0f, 0 + 4.0f),
            new Vector3(4.0f,  0.0f, 0 + 4.0f),
            new Vector3(6.0f,  0.0f, 0 + 4.0f),
            new Vector3(8.0f,  0.0f, 0 + 4.0f),
            new Vector3(0.0f,  0.0f, 2 + 4.0f),
            new Vector3(2.0f,  0.0f, 2 + 4.0f),
            new Vector3(4.0f,  0.0f, 2 + 4.0f),
            new Vector3(6.0f,  0.0f, 2 + 4.0f),
            new Vector3(8.0f,  0.0f, 2 + 4.0f),
        };

        private int vbo_ground, vbo_full_ground, vbo_water, vbo_log;

        private int vao_ground, vao_full_ground, vao_water, vao_log;

        private Shader _lighting_shader;

        float logPositionX = 4.0f;

        Vector2 lastPos;

        private Texture diffuse_map;
        private Texture specular_map;

        private Camera camera;

        private bool firstMove = true;

        float[] ground_block;
        float[] water_block;
        float[] full_ground_block;
        float[] log;

        public Game(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings)
            : base(gameWindowSettings, nativeWindowSettings)
        {
        }

        public void GenerateBuffer(ref int vao, ref int vbo, float[] objectToGenerate)
        {
            vao = GL.GenVertexArray();
            GL.BindVertexArray(vao);

            vbo = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, vbo);
            GL.BufferData(BufferTarget.ArrayBuffer, objectToGenerate.Length * sizeof(float), objectToGenerate, BufferUsageHint.StaticDraw);

            var vertexLocation = _lighting_shader.GetAttribLocation("position");
            GL.EnableVertexAttribArray(vertexLocation);
            GL.VertexAttribPointer(vertexLocation, 3, VertexAttribPointerType.Float, false, 8 * sizeof(float), 0);

            var textureLocation = _lighting_shader.GetAttribLocation("texcoords");
            GL.EnableVertexAttribArray(textureLocation);
            GL.VertexAttribPointer(textureLocation, 2, VertexAttribPointerType.Float, false, 8 * sizeof(float), 3 * sizeof(float));

            var normalLocation = _lighting_shader.GetAttribLocation("normal");
            GL.EnableVertexAttribArray(normalLocation);
            GL.VertexAttribPointer(normalLocation, 3, VertexAttribPointerType.Float, true, 8 * sizeof(float), 5 * sizeof(float));
        }

        public void DrawBlock(ref int vao, Vector3[] block_positions, int numsOfTriangles)
        {
            GL.BindVertexArray(vao);
            for (int i = 0; i < block_positions.Length; i++)
            {
                Matrix4 model = Matrix4.Identity;
                model *= Matrix4.CreateTranslation(block_positions[i]);
                model *= Matrix4.CreateScale(0.5f);
                _lighting_shader.SetMatrix("model", model);
                GL.DrawArrays(PrimitiveType.Triangles, 0, numsOfTriangles);
            }
        }

        public void DrawLog(ref int vao, float posX, int numsOfTriangles)
        {
            GL.BindVertexArray(vao);
            Matrix4 logModel = Matrix4.Identity;
            logModel *= Matrix4.CreateRotationZ((float)MathHelper.DegreesToRadians(90));
            logModel *= Matrix4.CreateScale(0.2f);
            logModel *= Matrix4.CreateTranslation(new Vector3(posX, 0.5f, 2.5f));
            _lighting_shader.SetMatrix("model", logModel);
            GL.DrawArrays(PrimitiveType.Triangles, 0, numsOfTriangles);
        }

        protected override void OnLoad()
        {
            base.OnLoad();

            CursorVisible = false;
            CursorGrabbed = true;

            GL.Enable(EnableCap.DepthTest);
           
            GL.ClearColor(0.15f, 0.15f, 0.15f, 1.0f);

            _lighting_shader = new Shader("../../../Shaders/shader.vert", "../../../Shaders/shader.frag");

            ground_block = ObjectReader.ReadObj("../../../ObjectModels/ground_block.obj");
            full_ground_block = ObjectReader.ReadObj("../../../ObjectModels/full_ground_block.obj");
            water_block = ObjectReader.ReadObj("../../../ObjectModels/water_block.obj");
            log = ObjectReader.ReadObj("../../../ObjectModels/log.obj");

            GenerateBuffer(ref vao_ground, ref vbo_ground, ground_block);
            GenerateBuffer(ref vao_full_ground, ref vbo_full_ground, full_ground_block);
            GenerateBuffer(ref vao_water, ref vbo_water, water_block);
            GenerateBuffer(ref vao_log, ref vbo_log, log);

            diffuse_map = Texture.LoadFromFile("../../../Textures/all_texture.png");
            specular_map = Texture.LoadFromFile("../../../Textures/all_texture_specular3.png");

            diffuse_map.Use(TextureUnit.Texture0);
            specular_map.Use(TextureUnit.Texture1);

            _lighting_shader.Use();

            _lighting_shader.SetInt("material.diffuse", 0);
            _lighting_shader.SetInt("material.specular", 1);
            _lighting_shader.SetFloat("material.shininess", 16.0f);

            _lighting_shader.SetVector3("light.ambient", new Vector3(0.7f, 0.7f, 0.7f));
            _lighting_shader.SetVector3("light.diffuse", new Vector3(0.7f, 0.7f, 0.7f));
            _lighting_shader.SetVector3("light.specular", new Vector3(1.0f, 1.0f, 1.0f));
            _lighting_shader.SetFloat("light.constant", 1.0f);
            _lighting_shader.SetFloat("light.linear", 0.09f);
            _lighting_shader.SetFloat("light.quadratic", 0.032f);

            _lighting_shader.SetFloat("light.cutOff", (float)Math.Cos(MathHelper.DegreesToRadians(12.5)));
            _lighting_shader.SetFloat("light.outerCutOff", (float)Math.Cos(MathHelper.DegreesToRadians(25.0)));

            camera = new Camera(new Vector3(0.0f, 1.0f, 4.0f), Size.X / (float)Size.Y);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            _lighting_shader.Use();

            DrawBlock(ref vao_ground, ground_positions, 36);
            DrawBlock(ref vao_full_ground, full_ground_positions, 36);
            DrawBlock(ref vao_water, water_positions, 36);
            DrawLog(ref vao_log, logPositionX, log.Length / 8);

            _lighting_shader.SetMatrix("view", camera.GetViewMatrix());
            _lighting_shader.SetMatrix("projection", camera.GetProjectionMatrix());

            _lighting_shader.SetVector3("viewPos", camera.Position);

            _lighting_shader.SetVector3("light.position", camera.Position);
            _lighting_shader.SetVector3("light.direction", camera.Front);

            logPositionX -= 0.001f; 
            if (logPositionX < 0.5f)
                logPositionX = 4.0f;

            SwapBuffers();
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            if (!IsFocused)
            {
                return;
            }

            var input = KeyboardState;

            if (input.IsKeyDown(Keys.Escape))
            {
                Close();
            }

            const float cameraSpeed = 3.0f;
            const float sensitivity = 0.07f;

            if (input.IsKeyDown(Keys.W))
            {
                camera.Position += camera.Front * cameraSpeed * (float)e.Time; // Forward
            }

            if (input.IsKeyDown(Keys.S))
            {
                camera.Position -= camera.Front * cameraSpeed * (float)e.Time; // Backwards
            }
            if (input.IsKeyDown(Keys.A))
            {
                camera.Position -= camera.Right * cameraSpeed * (float)e.Time; // Left
            }
            if (input.IsKeyDown(Keys.D))
            {
                camera.Position += camera.Right * cameraSpeed * (float)e.Time; // Right
            }
            if (input.IsKeyDown(Keys.Space))
            {
                camera.Position += camera.Up * cameraSpeed * (float)e.Time; // Up
            }
            if (input.IsKeyDown(Keys.LeftShift))
            {
                camera.Position -= camera.Up * cameraSpeed * (float)e.Time; // Down
            }


            var mouse = MouseState;

            if (firstMove)
            {
                lastPos = new Vector2(mouse.X, mouse.Y);
                firstMove = false;
            }
            else
            {
                var deltaX = mouse.X - lastPos.X;
                var deltaY = mouse.Y - lastPos.Y;
                lastPos = new Vector2(mouse.X, mouse.Y);

                camera.Yaw += deltaX * sensitivity;
                camera.Pitch -= deltaY * sensitivity;
            }
        }

        protected override void OnResize(ResizeEventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Size.X, Size.Y);
            camera.AspectRatio = Size.X / (float)Size.Y;
        }
    }
}