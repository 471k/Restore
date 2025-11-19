import { defineConfig } from "vite";
import plugin from "@vitejs/plugin-react";
import mkcert from "vite-plugin-mkcert";

// https://vitejs.dev/config/
export default defineConfig({
  build: {
    outDir: "../API/wwwroot",
    chunkSizeWarningLimit: 1024,
    emptyOutDir: true,
  },
  plugins: [plugin(), mkcert()],
  server: {
    //port: 30587,

    port: 3000,
  },
});
