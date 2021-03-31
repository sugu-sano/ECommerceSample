import "../styles/globals.css";

function SafeHydrate({ children }) {
  return (
    <div suppressHydrationWarning={true}>
      {typeof window === "undefined" ? null : children}
    </div>
  );
}

function MyApp({ Component, pageProps }) {
  return (
    <SafeHydrate>
      <Component {...pageProps} />
    </SafeHydrate>
  );
}

export default MyApp;
