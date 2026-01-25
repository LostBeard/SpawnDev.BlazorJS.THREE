namespace SpawnDev.BlazorJS.THREE
{
    /// <summary>
    /// Loads the THREE js library at app startup so it is ready for use for all components immediately
    /// </summary>
    /// <param name="JS"></param>
    public class THREEService(BlazorJSRuntime JS) : IAsyncBackgroundService
    {
        /// <inheritdoc/>
        public Task Ready => _Ready ??= LoadReady();
        Task? _Ready;
        async Task LoadReady()
        {
            // Requires import map

            // Load three.js
            // import * as THREE from 'three';
            using var three = await JS.Import("three");
            // globalThis.THREE.* = THREE.*;    
            three.ExportTo("THREE");

            // Load OrbitControls
            // import { OrbitControls } from 'OrbitControls';
            using var orbitControlsModule = await JS.Import("OrbitControls");
            // THREE.OrbitControls = OrbitControls;
            orbitControlsModule.ExportTo("THREE");

            // Load GLTFLoader
            // import { GLTFLoader } from 'GLTFLoader';
            using var gltfLoaderModule = await JS.Import("GLTFLoader");
            // THREE.GLTFLoader = GLTFLoader;
            gltfLoaderModule.ExportTo("THREE");

            // Load DragControls
            // import { DragControls } from 'DragControls';
            using var dragControlsModule = await JS.Import("DragControls");
            // THREE.DragControls = DragControls;
            dragControlsModule.ExportTo("THREE");

            // Load FlyControls
            // import { FlyControls } from 'FlyControls';
            using var flyControlsModule = await JS.Import("FlyControls");
            // THREE.FlyControls = FlyControls;
            flyControlsModule.ExportTo("THREE");

            // Load Stats (uses default export)
            // import Stats from 'Stats';
            using var statsModule = await JS.Import("Stats");
            // THREE.Stats = Stats;
            statsModule.ExportDefaultToAs("THREE", "Stats");
        }
    }
}
