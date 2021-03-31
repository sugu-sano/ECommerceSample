import '../styles/globals.css';
import React from 'react';
import type { AppProps } from 'next/app'

const SafeHydrate: React.FC = ({ children }) => {
  return (
    <div suppressHydrationWarning={true}>
      {typeof window === "undefined" ? null : children}
    </div>
  );
};

function MyApp({ Component, pageProps }: AppProps) {
  return (
    <SafeHydrate>
      <Component {...pageProps} />
    </SafeHydrate>
  );
}

export default MyApp;
